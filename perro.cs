public class perro 
//declara las variable
//declara la variable isbn y paginas como entero

{ private int altura;
//declara la variable titulo y autor como alfanumerioco
private string Raza="",nombre="",color="",genero="";
  //guarda en la variable titulo
   public void getaltura()
   
   {
        Console.WriteLine(this.altura);
    }
    // lama la variable titulo
public void setaltura(int largo){
        this.altura=largo;
}
// guarda en la variable autor
    public void getRaza(){
        Console.WriteLine(this.Raza);
    }
    //lama la variable autor
public void setRaza(string nombrer){
        this.Raza=nombrer;
}
// guarda la variable isbn
    public void getnombre(){
        Console.WriteLine(this.nombre);
    }
    //llama la variable ibsn
public void setnombre(string nombreP){
        this.nombre=nombreP;
}
    public void getcolor(){
        Console.WriteLine(this.color);
    }
    //llama la variable ibsn
public void setcolor(string color1){
        this.color=color1;

}
    public void getgenero(){
        Console.WriteLine(this.genero);
    }
    //llama la variable ibsn
public void setgenero(string machi){
        this.genero=machi;

}
public void tostring(){ Console.WriteLine("El Perro se LLama "+this.nombre);
                        Console.WriteLine("Raza: "+this.Raza);
                        Console.WriteLine("Genero: "+this.genero);
                        Console.WriteLine("Altura: "+this.altura+"Cm");
                        Console.WriteLine("Color: "+this.color);
}

}

