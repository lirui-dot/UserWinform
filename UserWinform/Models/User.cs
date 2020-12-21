using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserWinform.Models
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string FileUrl { get; set; }
    }
}
