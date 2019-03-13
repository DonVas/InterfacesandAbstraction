namespace BorderControl
{
    public class BasePerson: IRebellable
    {
        protected BasePerson(string id)
        {
            this.Id = id;
        }

        public string Id { get;   private set; }       
    }
}
