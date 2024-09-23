using AVTOREG.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AVTOREG.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                User userModel = CoreDbConnect.DB.Users.FirstOrDefault(u => u.Login == TbLogin.Text && u.Password == PbPassoword.Password);
                if (userModel != null)
                {
                    switch (userModel.RoleID)
                    {
                        case 1:
                            new AdminWindow().ShowDialog();
                            break;
                        case 2:
                            new DevWindow().ShowDialog();
                            break;
                        case 3:
                            new UserWindow().ShowDialog();
                            break;

                    }


                }

                else
                {
                    new ErrorWindow().ShowDialog();
                }

                }
                Catch(Exception);
                    {

                    new ErrorWindow().ShowDialog();



                }

            }
    }
    } 
