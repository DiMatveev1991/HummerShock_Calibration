namespace DAL_DbHammer.DAL
{
	public class SamplRefAcc : Entity
	{
		public double PulseTimeMs { get; set; }
		public double AmplitudeImpuls { get; set; }
		public double Сoefficient { get; set; }
		public string dimension { get; set; }
		public virtual RefAccelerometer Accelerometer { get; set; }
	}
}
