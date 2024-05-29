using Spectre.Console;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    public class Location
    {
        private readonly string _nameLocation;
        private readonly string _descriptionLocation;
        private readonly INonPlayerCharacter _character;

        public Location(string nameLocation, string descriptionLocation, INonPlayerCharacter character)
        {
            _nameLocation = nameLocation;
            _descriptionLocation = descriptionLocation;
            _character = character;
        }

        public string NameLocation 
        { 
            get { return _nameLocation; }            
        }

        public string DescriptionLocation
        {
            get => _descriptionLocation;
        }

        public INonPlayerCharacter Character 
        { 
            get { return _character; } 
        }

        

    }
}
