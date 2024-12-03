using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoaiDTO
    {
<<<<<<< HEAD
        public TheLoaiDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.TenTheLoai = row["TenTheLoai"].ToString();
            if (row["MoTa"].ToString() != "")
                this.MoTa = row["MoTa"].ToString();
            else
                this.MoTa = "";
        }
        public TheLoaiDTO()
        {
                
        }
        public string Id { get; set; }
=======
        public int Id { get; set; }
>>>>>>> 6683445631f7c1d1cb20305a48718913491dc7d4
        public string TenTheLoai { get; set; }
        public string MoTa { get; set; }
    }

}
