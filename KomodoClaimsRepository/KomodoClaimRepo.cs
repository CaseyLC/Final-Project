using KomodoClaims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsRepository
{
    public class Repository
    {
        private Queue<Claims> _claims = new Queue<Claims>();
        public Queue<Claims> GetList()
        {
            return _claims; // RETURNS THE QUEUE LIST
        }

        public void AddClaim(Claims newClaim)
        {
            _claims.Enqueue(newClaim); // ADDS A NEW CLAIM
        }

        public void RemoveClaim()
        {
            _claims.Dequeue(); // REMOVE THE TOP CLAIM
        }

        public void IsValid(Claims claim) // IS WITHIN 30 DAYS OF
        {
            if (claim.DateOfClaim < claim.DateOfIncident)
                claim.DateOfClaim = claim.DateOfIncident;

            TimeSpan difference = claim.DateOfClaim - claim.DateOfIncident;

            if (difference.Days <= 30)
            {
                claim.IsValid = true;
            }
            else
                claim.IsValid = false;
        }
    }
}