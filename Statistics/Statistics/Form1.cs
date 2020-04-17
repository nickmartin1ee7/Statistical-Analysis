// Author:			Nicholas Martin
// Date:			12/10/2019
// Description:     Primary function: Calculate statistical properties of a dataset. Secondary function: Generates random dataset.

using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Global variables
        private const char headerChar = '#';    // Known header char for save files

        List<int> dataSet = new List<int>(); // Dataset containing random gen contents
        int n;          // Line count

        double sum,     // Sum total
               avg,     // Avg of dataSet
               stdDev,  // Standard deviation
               stdErr,  // Standard error
               expVal,  // Null hypothesis, expected value
               zScore;  // Z-Test score based off expected value

        bool once = false;  // Flag for if calculated at least once

        // Clear button (form cancel button) resets all textboxes & file name label to default strings
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ProcessWorking();
            once = false;
            linesTextBox.Text = "";
            sumTextBox.Text = "";
            averageTextBox.Text = "";
            stdDeviationTextBox.Text = "";
            stdErrorTextBox.Text = "";
            fileNameLabel.Text = "";
            nullHypTextBox.Text = "";
            roundChkBox.Checked = true;
            randNTextBox.Text = "";
            randMinTextbox.Text = "";
            randMaxTextBox.Text = "";
            zTestTextBox.Text = "";
            chooseFileBtn.Text = "Choose file...";
            chooseFileBtn.Select();
            dataSet.Clear();
            ProcessDone();
        }

        private void ProcessWorking()
        {
            watchTimeLabel.Text = "Working...";
        }
        
        private void ProcessDone()
        {
            watchTimeLabel.Text = "Done!";
        }

        private void ProcessError()
        {
            watchTimeLabel.Text = "Error!";
        }

        private void roundChkBox_CheckedChanged(object sender, EventArgs e) => DisplayResults();

        // When null hypothesis textbox's content changes, live update Z-Score value, and re-render the display boxes
        private void nullHypTextBox_TextChanged(object sender, EventArgs e)
        {
            if (once && double.TryParse(nullHypTextBox.Text, out expVal))
            {
                zScore = CalcZScore(expVal, avg, stdErr);
                DisplayResults();
            }
        }

        // Saves results and dataset to text file using file dialog
        private async void saveBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Save file button clicked");
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK && dataSet.Count > 0)
                    {
                        string fileName = saveFileDialog.FileName;
                        fileNameLabel.Text = fileName;
                        ProcessWorking();
                        await Task.Run(() =>
                        {
                            using (StreamWriter streamWriter = new StreamWriter(fileName))
                            {
                                // Stats
                                streamWriter.WriteLine($"#\t Lines:\t\t\t\t{n}\n" +
                                    $"#\t Average:\t\t\t{avg}\n" +
                                    $"#\t Std. Deviation:\t{stdDev}\n" +
                                    $"#\t Std. Error:\t\t{stdErr}\n" +
                                    $"#\t Z-Test:\t\t\t{zScore}");

                                // Dataset
                                int dataSetX = 0;
                                int dataSetY = n;
                                foreach (int val in dataSet)
                                {
                                    ++dataSetX;
                                    if (dataSetX < dataSetY)
                                    {
                                        streamWriter.WriteLine($"{val}");
                                    }
                                    else
                                    {
                                        streamWriter.Write($"{val}");
                                    }
                                }
                            }
                        });
                        MessageBox.Show($"Saved to: {fileName}", "Finished");
                        ProcessDone();
                    }
                }
            }
            catch (Exception exp)
            {
                ProcessError();
                MessageBox.Show($"Save unsuccessful!\n{exp.Message}", "Error");
            }
        }

    // Button that pops-up a file dialog, parses file, and populate dataset with file contents
    private async void chooseFileBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Load file button clicked");
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|Your mother (*.fat)|*.fat";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ProcessWorking();
                        bool badData = false;   // No bad data exists by default
                        string fileName = openFileDialog.FileName;
                        fileNameLabel.Text = fileName;
                        StreamReader streamReader = new StreamReader(fileName);
                        Console.WriteLine("File loaded into Dataset!");

                        // Parse in
                        await Task.Run(() =>
                        {
                            foreach (string line in streamReader.ReadToEnd().Split('\n'))
                            {
                                if (int.TryParse(line, out int lineInt))
                                {
                                    dataSet.Add(lineInt);
                                }
                                //Format understanding
                                else if (line[0] != headerChar || line[0] != '\n')  // Exclude # or newLines
                                {
                                    badData = true;
                                }
                            }
                        });
                        if (!badData)
                        {
                            MessageBox.Show("Contents partially imported!\n\nData missing? Make sure the file contents are in the correct format.\nEx:\t1\n\t2\n\t3\n\t4\n\t5", "Warning");
                        }
                        else
                        {
                            MessageBox.Show("Contents imported successfully!", "Finished");
                        }
                        ProcessDone();
                    }
                }
                chooseFileBtn.Text = "Choose another file...";
            }
            catch (Exception exp)
            {
                ProcessError();
                MessageBox.Show($"Failed to open file!\n{exp.Message}", "Error");
            }
        }

        // Calculates statistictal propteries of a dataset and calls DisplayResults()
        private async void calcBtn_Click(object sender, EventArgs e)
        {
            if (dataSet.Count > 0 && !once)
            {
                Stopwatch watch = Stopwatch.StartNew();
                try
                {
                    ProcessWorking();
                    await Task.Run(() =>
                    {
                        sum = calcSum(dataSet, out n);
                        avg = calcAvg(sum, n);
                        stdDev = CalcStdDev(dataSet, avg, n);
                        stdErr = CalcStdErr(stdDev, n);
                    });
                    if (!double.TryParse(nullHypTextBox.Text, out expVal))
                    {
                        expVal = avg;
                        nullHypTextBox.Text = $"{avg}";
                    }
                    zScore = CalcZScore(expVal, avg, stdErr);
                    watch.Stop();
                    long elapsedTime = watch.ElapsedMilliseconds;
                    Console.WriteLine($"Took: {elapsedTime} ms");
                    watchTimeLabel.Text = $"Elapsed time: {elapsedTime} ms";
                    once = true;
                    DisplayResults();
                }
                catch (Exception exp)
                {
                    MessageBox.Show($"Error attempting to calculate!\n{exp.Message}", "Error");
                    ProcessError();
                }
            }
            else
            {
                MessageBox.Show("Error!\nNo data imported or has already been calculated.");
                ProcessError();
            }
        }

        // Calculates sum of dataset
        static double calcSum(List<int> dataSet, out int n)
        {
            n = 0;
            int sum = 0;
            foreach (int value in dataSet) {
                sum += value;
                n += 1;
            }
            return sum;
        }

        // Calculates average of dataset
        static double calcAvg(double sum, int n)
        {
            double avg = sum / n;
            return avg;
        }

        // Calculates standard deviation of dataset
        static double CalcStdDev(List<int> dataSet, double avg, int n)
        {
            double diff = 0;
            foreach (int value in dataSet) { diff += Math.Pow(value - avg, 2); }
            double stdDev = Math.Sqrt(diff / n);
            return stdDev;
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent) => MessageBox.Show("Author:\tNick Martin\nGithub:\thttps://github.com/nickmartin1ee7/Statistical-Analysis", "Credits");

        // Calculates standard error of dataset
        static double CalcStdErr(double stdDev, int n)
        {
            double stdErr = stdDev / Math.Sqrt(n);
            return stdErr;
        }


        // Calculates Z-Test result/score of dataset
        static double CalcZScore(double expVal, double avg, double stdErr)
        {
            double zScore = Math.Abs((avg - expVal) * stdErr);
            return zScore;
        }

        // Button that calls random number generation method and times the milliseconds it takes to generate set
        private async void randGenBtn_Click(object sender, EventArgs e)
        {
            once = false;
            try
            {
                ProcessWorking();
                Stopwatch watch = Stopwatch.StartNew();
                int randN = int.Parse(randNTextBox.Text);
                int randMin = int.Parse(randMinTextbox.Text);
                int randMax = int.Parse(randMaxTextBox.Text);
                await Task.Run(() => { dataSet.AddRange(GenerateRandom(randN, randMin, randMax)); }); // Returns List<int> to List dataSet<int>
                watch.Stop();
                long elapsedTime = watch.ElapsedMilliseconds;
                Console.WriteLine($"Took: {elapsedTime} ms");
                watchTimeLabel.Text = $"Elapsed time: {elapsedTime} ms";
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Error generating random number!\n{exp.Message}", "Error");
            }
        }

        // Generates random number set
        private List<int> GenerateRandom(int randN, int randMin, int randMax)
        {
            List<int> output = new List<int>();
            Console.WriteLine($"Random: size:{randN} min:{randMin}, max:{randMax}");
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 1; i <= randN; i++)
            {
                output.Add(random.Next(randMin, randMax));
            }
            return output;
        }

        // Displays results by updating text boxes. Takes rounding checkbox into consideration
        private void DisplayResults()
        {
            if (once)
            {
                if (roundChkBox.Checked)
                {
                    linesTextBox.Text = $"{n:N0}";
                    sumTextBox.Text = $"{sum}";
                    averageTextBox.Text = $"{avg:F4}";
                    stdDeviationTextBox.Text = $"{stdDev:F4}";
                    stdErrorTextBox.Text = $"{stdErr:F4}";
                    zTestTextBox.Text = $"{zScore:F4}";
                }
                else
                {
                    linesTextBox.Text = $"{n:N0}";
                    sumTextBox.Text = $"{sum}";
                    averageTextBox.Text = $"{avg}";
                    stdDeviationTextBox.Text = $"{stdDev}";
                    stdErrorTextBox.Text = $"{stdErr}";
                    zTestTextBox.Text = $"{zScore:F10}";
                }
            }
        }
    }
}