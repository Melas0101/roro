﻿using System;

namespace Roro.Activities.Element
{
    public sealed class Press : Activity
    {
        public InArgument<bool> Element { get; set; }

        public InArgument<KeyboardKey> Value { get; set; }

        public override void Execute(ActivityContext context)
        {
            throw new NotImplementedException();
        }
    }
}
