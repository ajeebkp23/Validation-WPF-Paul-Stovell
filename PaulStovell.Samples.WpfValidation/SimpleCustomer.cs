using System;
using System.Collections.Generic;
using System.Text;

namespace PaulStovell.Samples.WpfValidation
{
    public class SimpleCustomer
    {
        private string _name;
        private string _address;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (String.IsNullOrEmpty(_name))
                {
                    throw new ApplicationException("Customer name is mandatory.");
                }
            }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
}
