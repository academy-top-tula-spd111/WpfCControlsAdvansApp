using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfCControlsAdvansApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            calendar.BlackoutDates.Add(
                    new CalendarDateRange(new DateTime(2022, 12, 1), 
                                            new DateTime(2022, 12, 4)));
            calendar.BlackoutDates.Add(
                    new CalendarDateRange(new DateTime(2022, 12, 8),
                                            new DateTime(2022, 12, 12)));
            calendar.BlackoutDates.Add(
                    new CalendarDateRange(new DateTime(2022, 12, 18),
                                            new DateTime(2022, 12, 22)));
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            (sender as Slider).SelectionEnd = (sender as Slider).Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calendar.BlackoutDates.Add(
                    new CalendarDateRange(new DateTime(2022, 12, 15),
                                            new DateTime(2022, 12, 16)));
            //BackgroundWorker worker = new BackgroundWorker();
            //worker.WorkerReportsProgress = true;
            //worker.DoWork += DoWork;
            //worker.ProgressChanged += ProgressChanged;

            //worker.RunWorkerAsync();
        }

        void DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        void ProgressChanged(object sender, ProgressChangedEventArgs e) 
        {
            progress.Value = e.ProgressPercentage;
        }
    }
}
