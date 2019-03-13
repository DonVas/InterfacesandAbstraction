namespace BorderControl
{
    public class Robot : BasePerson
    {
        private string model;
  
        public Robot(string model, string id) 
            : base(id)
        {
            this.model = model;
        }
    }
}
