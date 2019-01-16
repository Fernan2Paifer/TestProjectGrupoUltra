using System;

namespace WebClient.Models
{
public partial class Prestamo
	{
	public long IdPrestamo { get; set; }

	public long Monto { get; set; }


	public DateTime Fecha { get; set; }


	public long FkTrabajador { get; set; }


	public object FkTrabajadorNavigation { get; set; }
	}
}
