class Program {
  public static char[,] grid = {{'-','-','-'},{'-','-','-'},{'-','-','-'}};
  public static int filledSpaces = 0;
  public static void Main (string[] args) {
    bool gameOver = false;
    int x = -1;
    int y = -1;
    Console.WriteLine("WELCOME TO NOUGHTS AND CROSSES\n\n");
    displayGrid();

    while(!gameOver & filledSpaces < 9){
      x = -1;
      y = -1;
      do{
        Console.WriteLine("\nPlayer One (O), make your move - enter your coordinates using x and y\n Enter your x value:");
        x = Convert.ToInt32(Console.ReadLine()) - 1;
        
        Console.WriteLine("\nNow enter your y value:");
        y = Convert.ToInt32(Console.ReadLine()) - 1;
        
      }while(!checkMove(x,y));
      
      oMove(x,y);
      displayGrid();

      x = -1;
      y = -1;
      
      do{
        if(checkGameWon()=='o' | (filledSpaces == 9)){
          break;
          }
          
        Console.WriteLine("\nPlayer Two (X), make your move - enter your coordinates using x and y\n Enter your x value:");
        x = Convert.ToInt32(Console.ReadLine()) - 1;
        
        Console.WriteLine("\nNow enter your y value:");
        y = Convert.ToInt32(Console.ReadLine()) - 1;
        
      }while(!checkMove(x,y));

      if(checkGameWon() != 'o' & filledSpaces < 9 ){
        xMove(x,y);
        displayGrid();
      }
      

      if(checkGameWon()=='o'){
        gameOver = true;
        Console.WriteLine("O has won the game!");
      }else if(checkGameWon() =='x'){
        gameOver = true;
        Console.WriteLine("X has won the game!");
      }else if(filledSpaces == 9){
        gameOver = true;
        Console.WriteLine("No winner this time, better luck next time");
      }
    }
    
  }
  public static void displayGrid(){
    for(int i = 0; i < 3; i++){
      Console.WriteLine("-----------");
      for(int j = 0; j < 3; j++){
        Console.Write($"|{grid[i,j]}| ");
      }
      Console.WriteLine("\n-----------");
    }
  }
  
  public static void oMove(int x, int y){
      grid[x,y] = 'O';
      filledSpaces++;
    
    }

    public static void xMove(int x, int y){
      grid[x,y] = 'X';
      filledSpaces++;
    
    }

  
  
  public static bool checkMove(int x, int y)
  {
    bool valid = false;
    if(x < 3 & x >= 0){
      if(y < 3 & y>= 0){
        if(grid[x,y] == '-'){
          valid = true;
          }else{
          Console.WriteLine("Space taken, please try again");
          }
      }else{
        Console.WriteLine("Invalid input, please enter values between 1 and 3");
      }
    }else{
        Console.WriteLine("Invalid input, please enter values between 1 and 3");
      }
     return valid;
  }

  
  public static char checkGameWon()
  {
    int ohoriz = 0;
    int overt = 0;
    int xhoriz = 0;
    int xvert = 0;

    
   for(int i = 0; i < 3; i++){
     
      for(int j = 0; j < 3; j++){
        if(grid[i,j]=='O'){
          ohoriz++;          
        }else if(grid[i,j] == 'X'){
          xhoriz++;
        }
        
        
        
        if(grid[j,i] == 'O'){
          overt++;
        }else if(grid[j,i] == 'X'){
          xvert++;
        }    
      }
        if(ohoriz < 3){
          ohoriz = 0;
        }
        if(xhoriz < 3){
          xhoriz = 0;
        }
        if(overt < 3){
          overt = 0;
        }
        if(xvert < 3){
          xvert = 0;
        
        }
     
     
    }
    if((ohoriz + overt) > (xhoriz + xvert)){
      return 'o';
    }else if(xhoriz + xvert > ohoriz + overt){
      return 'x';
    }else if(xhoriz + xvert == 0){
      return 'n';
    }else{
      return 'd';
    }
  }
}

