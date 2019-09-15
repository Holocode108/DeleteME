using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_2019_Task1_Memo1
{
  class ResourceBuilding : Building
  {
    string minerals;
    int resourcesGenerated;
    int rpr = 2;
    int resourcePool = 100;
    public ResourceBuilding(int x, int y, int h, string f, string sy) :base(x,y,h,f,sy)
    {
      
    }
    public override void Destruction()
    {

    }
    public override string ToString()
    {
      return"";
    }
    public void ResourceGeneration()
    {
      for (int i = 0; i < resourcePool; i += rpr)
      {
        if(health<0)
        {
          break;
        }
        else
        {
          
        }
      }
    }
  }
}
