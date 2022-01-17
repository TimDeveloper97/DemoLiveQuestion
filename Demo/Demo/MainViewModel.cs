using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties
        private QuestionModel questionModel;

        public QuestionModel QuestionModel { get => questionModel; set => SetProperty(ref questionModel, value); }

        public ICommand SubmitCommand => new Command(() =>
        {
            
        });
        #endregion


        public MainViewModel() : base("Main")
        {

        }

    }
}
