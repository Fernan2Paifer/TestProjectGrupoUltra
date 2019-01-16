using System;

namespace WebClient.Models
{
public class Ahorro
	{
	public long IdAhorro { get; set; }


	public long Monto { get; set; }

	public DateTime Fecha { get; set; }

	public long FkTrabajador { get; set; }

	public object FkTrabajadorNavigation { get; set; }
	}
}
