using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoreApiWithJWT.Model
{
    public class UserModel
    {
        public Int64 UserID { get; set; }
        //public Int64 FacilityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
        [JsonIgnore]
        public string token { get; set; }
    }
}
