using System;
using System.Collections.Generic;
using System.Text;
using GiantKillers.Enums;

namespace GiantKillers.Utils
{
    class Die
    {
        public IReadOnlyList<int> FaceValues { get; }

        private Random rand = new Random();

        public Die(IReadOnlyList<int> faceValues)
        {
            FaceValues = faceValues;
        }

        public Die(DieType type)
        {
            FaceValues = type.GetFaceValues();
        }

        public int Roll()
        {
            return FaceValues[rand.Next(FaceValues.Count)];
        }
    }
}
