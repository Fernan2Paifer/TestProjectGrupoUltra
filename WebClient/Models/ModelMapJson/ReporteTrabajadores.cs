using System;

namespace WebClient.Models
{
public partial class ReporteTrabajadores
	{
	public Employee Employee { get; set; }


	public long Antiguedad { get; set; }


	public long MontoAhorrado { get; set; }
	}

public partial class Employee
	{
	public long IdTrabajador { get; set; }


	public string Nombre { get; set; }


	public object Apellidos { get; set; }


	public long MontoAinicial { get; set; }


	public DateTime FechaInicioRl { get; set; }


	public bool Inscrito { get; set; }


	public string FkUser { get; set; }


	public object FkUserNavigation { get; set; }


	public object[] EAhorro { get; set; }

	public object[] EPrestamo { get; set; }
	}
}
