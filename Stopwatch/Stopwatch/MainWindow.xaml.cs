using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Threading;
using Stopwatch.Properties;
using Microsoft.Win32;
using System.IO;
using System.Collections.ObjectModel;

namespace Stopwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableStopwatch stopwatch = new ObservableStopwatch();
        private ObservableCollection<TimeSpan> splitTimes = new ObservableCollection<TimeSpan>();

        public ObservableStopwatch Stopwatch
        {
            get { return stopwatch; }
        }

        public ObservableCollection<TimeSpan> SplitTimes
        {
            get { return splitTimes; }
        }

        private string format = @"hh\:mm\:ss\.ff";
        private bool startStopInSplitTimes;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            this.Width = Settings.Default.MainWindowWidth;
            this.Height = Settings.Default.MainWindowHeight;
            this.Top = Settings.Default.MainWindowTop;
            this.Left = Settings.Default.MainWindowLeft;
            txtDisplay.Foreground = new SolidColorBrush(Settings.Default.DisplayForegroundColor);
            grdDisplay.Background = new SolidColorBrush(Settings.Default.DisplayBackgroundColor);
            this.startStopInSplitTimes = Settings.Default.StartStopInSplitTimes;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;

            if (this.startStopInSplitTimes)
                this.splitTimes.Add(stopwatch.Elapsed);
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Stop();
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;

            if (this.startStopInSplitTimes)
                this.splitTimes.Add(stopwatch.Elapsed);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.splitTimes.Add(stopwatch.Elapsed);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Reset();
            this.splitTimes.Clear();
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;

            if (this.startStopInSplitTimes)
                this.splitTimes.Add(stopwatch.Elapsed);
        }

        private void mFileSaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            bool? dialogResult = sfd.ShowDialog();
            if (dialogResult ?? false)
            {
                StringBuilder sb = new StringBuilder();
                foreach (TimeSpan splitTime in this.splitTimes)
                {
                    sb.AppendLine(splitTime.ToString());
                }
                File.WriteAllText(sfd.FileName, sb.ToString());
            }
        }

        private void mFileExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mToolsOptions_Click(object sender, RoutedEventArgs e)
        {
            OptionsDialog optionsDialog = new OptionsDialog();
            optionsDialog.Owner = this;

            SolidColorBrush colorBrush = (SolidColorBrush)txtDisplay.Foreground;

            optionsDialog.DisplayForegroundColor = colorBrush.Color;
            colorBrush = (SolidColorBrush)grdDisplay.Background;
            optionsDialog.DisplayBackgroundColor = colorBrush.Color;

            bool? dialogResult = optionsDialog.ShowDialog();

            if (dialogResult ?? false)
            {
                this.startStopInSplitTimes = optionsDialog.StartStopInSplitTimes;
                txtDisplay.Foreground = new SolidColorBrush(optionsDialog.DisplayForegroundColor ?? Colors.Black);
                grdDisplay.Background = new SolidColorBrush(optionsDialog.DisplayBackgroundColor ?? Colors.White);
            }
        }

        private void mHelpAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.Owner = this;
            aboutDialog.ShowDialog();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            Settings.Default.MainWindowLeft = this.Left;
            Settings.Default.MainWindowTop = this.Top;
            Settings.Default.MainWindowHeight = this.Height;
            Settings.Default.MainWindowWidth = this.Width;

            SolidColorBrush colorBrush = (SolidColorBrush)txtDisplay.Foreground;
            Settings.Default.DisplayForegroundColor = colorBrush.Color;
            colorBrush = (SolidColorBrush)grdDisplay.Background;
            Settings.Default.DisplayBackgroundColor = colorBrush.Color;

            Settings.Default.StartStopInSplitTimes = this.startStopInSplitTimes;

            Settings.Default.Save();

            base.OnClosing(e);
        }

    }
}
