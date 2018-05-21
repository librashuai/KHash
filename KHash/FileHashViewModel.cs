using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KHash
{
    class FileHashViewModel:INotifyPropertyChanged
    {
        public string FilePath { get; set; }

        private string result = "";

        public event PropertyChangedEventHandler PropertyChanged;

        public string Result
        {
            get{return result;}
            set
            {
                if(value != this.result)
                {
                    result = value;
                    NotifyPropertyChanged();
                } 
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CalcHash()
        {
            Result = HashModel.Instance.CalcFileHash(FilePath);
        }
    }
}
