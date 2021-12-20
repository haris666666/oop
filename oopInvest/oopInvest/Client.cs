using System;
using System.Collections.Generic;
using System.Text;

namespace oopInvest
{
    class Client
    {
        private string _name;
        private string _title;
        private string _property;
        private string _address;
        private long _phone;

        public Client() { }
        public Client(string Name, string Title, string Property, string Address, long Phone)
        {
            _name = Name;
            _title = Title;
            _property = Property;
            _address = Address;
            _phone = Phone;
        }
        
        public string GetName()
        {
            return _name;

        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetProperty()
        {
            return _property;
        }
        public string GetAddress()
        {
            return _address;

        }
        public long GetPhone()
        {
            return _phone;
        }

        public void SetName(string Name)
        {
            _name = Name;

        }
        public void SetTitle(string Title)
        {
            _title = Title;
        }
        public void SetProperty(string Property)
        {
            _property = Property;
        }
        public void SetAddress(string Address)
        {
            _address = Address;

        }
        public void SetPhone(int Phone)
        {
            _phone = Phone;
        }
    }
}
