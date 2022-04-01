using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI{
    public class Composite : IComponent{
        
        List<IComponent> components = new List<IComponent>();

        public string getPart(){
            string part = null;
            for(int i = 0; i < components.Count; i++){
                part = components.ElementAt(i).getPart();

            }
            return part;
        }

        public void addPart(IComponent component){
            components.Add(component);

        }
        public void addPart(IComponent component, IComponent IComponent2, IComponent IComponent3, IComponent IComponent4, IComponent IComponent5){
            components.Add(component);
        }
        
        public void removePart(IComponent component){
            components.Remove(component);
        }
    }
}