using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KHash
{
    class StringHashViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public string Input { get; set; }
        private string result = "";
        public string Result
        {
            get { return result; }
            set { result = value; NotifyPropertyChanged(); }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Calc()
        {
            Result = HashModel.Instance.CalcStringHash(Input);
        }
    }
}
