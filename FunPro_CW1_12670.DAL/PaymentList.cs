using System.Collections.Generic;

namespace FunPro_CW1_12670.DAL
{
    public class PaymentList
    {
        public List<Payment> GetAllPayments()
        {
            return new PaymentManager().GetAll();
        }
    }
}
