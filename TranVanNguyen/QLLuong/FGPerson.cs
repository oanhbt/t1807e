using System;
using PersonProfile;
namespace FGPersonPro
{
    public class FGPerson : Person, IElectricity
    {
        private String nation;
        private int nationalld;
        private double thanhtien;

        public double invoice() {
            if(this.kw <= this.quota) {
                this.thanhtien = this.kw*this.price*2.5;
            }else {
                this.thanhtien = this.kw*this.price*2.5 + (this.kw-this.quota)*2.5*1.5;
            }
            return this.thanhtien;
        }

        
        public void pay(double thanhtien) {
            // TODO Auto-generated method stub
            this.wallet = this.wallet - this.thanhtien;
        }

        
        public void retrievePhoneNumber() {
            // TODO Auto-generated method stub
            Console.WriteLine("Phone Number: +00["+this.phone+"]");
        }
    }
}
