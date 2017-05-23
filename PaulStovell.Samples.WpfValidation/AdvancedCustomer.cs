using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace PaulStovell.Samples.WpfValidation
{
    public class AdvancedCustomer : IDataErrorInfo, INotifyPropertyChanged
    {
        private string _name;
        private string _address;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("Address"));
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }

        #endregion

        #region IDataErrorInfo Members

        public string Error
        {
            get { return this[null]; }
        }

        public string this[string propertyName]
        {
            get
            {
                string result = string.Empty;
                propertyName = propertyName ?? string.Empty;
                if (propertyName == string.Empty || propertyName == "Name")
                {
                    if (string.IsNullOrEmpty(this.Name))
                    {
                        result += "Name is mandatory." + Environment.NewLine;
                    }
                }

                if (propertyName == string.Empty || propertyName == "Address")
                {
                    if (string.IsNullOrEmpty(this.Address) || this.Address.Length > 30)
                    {
                        result += "Address is mandatory and must be less than 30 letters." 
                            + Environment.NewLine;
                    }
                }

                return result.TrimEnd();
            }
        }

        #endregion
    }
}
