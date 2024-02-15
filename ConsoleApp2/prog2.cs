class Cars 
{

   private string color; 
   private int maxspeed; 

   public string Color
   {get; set; }

   public int Maxspeed
   {
    get { return maxspeed;}
    set { maxspeed= value; }
   }

   public void fullThrottle(){

    Console.WriteLine("Those valuable cars is going as fast as it can!");


   }
}