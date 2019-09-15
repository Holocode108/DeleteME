using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_2019_Task1_Memo1
{
  class FactoryBuilding :Building
  {
    public FactoryBuilding(int x, int y, int h, string f, string sy) : base(x, y, h, f, sy)
    {

    }
    string meleeUnit;
    string rangedUnit;
    int spawnPoint;
    private int productionSpeed;

    public int ProductionSpeed
    {
      get { return productionSpeed; }
      set { productionSpeed = value; }
    }
  
    public void UnitSpawn()
    {
      MeleeUnit meleeUnit = new MeleeUnit(xPos,yPos,health, 5,0,2,"M");
    }

    public override void Destruction()
    {

    }
    public override string ToString()
    {
      return "";
    }

  }
}
