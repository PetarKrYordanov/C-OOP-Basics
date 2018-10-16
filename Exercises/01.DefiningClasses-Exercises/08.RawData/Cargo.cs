
    class Cargo
    {
    public Cargo(int weight,string type)
    {
        this.weight = weight;
        this.type = type;
    }
    private int weight;
    private string type;

    public int Weigtht { get => weight; set => weight = value; }
    public string Type { get => type; set => type = value; }
}

