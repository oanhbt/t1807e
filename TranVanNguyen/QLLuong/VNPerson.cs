using System;
using PersonProfile;
namespace VNPersonPro
{
    public class VNPerson : Person, IElectricity
    {
        private double thanhtien;

        public double invoice() {
            // TODO Auto-generated method stub
            if(this.kw <= this.quota) {
                this.thanhtien = this.kw*this.price;
            }else {
                this.thanhtien = this.kw*this.price+(this.kw-this.quota)*this.price*1.5;
            }
            return this.thanhtien;
        }

        
        public void pay(double thanhtien) {
            // TODO Auto-generated method stub
            this.wallet = this.wallet - this.thanhtien;
        }

        
        public void retrievePhoneNumber() {
            // TODO Auto-generated method stub
            Console.WriteLine("Phone Number: +84["+this.phone+"]");
        }
    }
}
