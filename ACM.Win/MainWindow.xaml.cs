﻿using System;
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
using ACM.BL;

namespace ACM.Win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            //Populate the customer instance

            var order = new Order();
            // Populate the order instance

            var payment = new Payment();
            // Populate the payment info from the UI

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment,
                                allowSplitOrders:false, 
                                emailReceipt:true);
        }

        private void brnCalculate_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculatePercentageOfGoalSteps(this.TxtGoal.Text,
                                                                this.TxtSteps.Text);
            ResultLabel.Content = $"You reached {result}% of your goal!";
        }
    }
}
