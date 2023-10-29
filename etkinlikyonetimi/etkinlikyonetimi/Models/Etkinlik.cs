using System.ComponentModel.DataAnnotations;

namespace etkinlikyonetimi.Models
{
	public class Etkinlik
	{
        public int Id { get; set; }
		public string Baslik { get; set; }
		public string Yer { get; set; }
        public string UcretTip { get; set; }
        public int Ucret { get; set; }

		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Zaman { get; set; }
		public string Aciklama { get; set; }
	}
}
