﻿namespace WinterIsComing
{
    using WinterIsComing.Contracts;
    using WinterIsComing.Core;

    public class WinterIsComingMain
    {
        private const int MatrixRows = 5;

        private const int MatrixCols = 5;

        private static void Main()
        {
            IInputReader consoleReader = new ConsoleReader();
            var consoleWriter = new ConsoleWriter { AutoFlush = true };

            IUnitContainer unitMatrix = new MatrixContainer(MatrixRows, MatrixCols);
            ICommandDispatcher commandDispatcher = new ExtendedCommandDispatcher();
            IUnitEffector unitEffector = new ExtendedUnitEffector();

            var engine = new Engine(unitMatrix, consoleReader, consoleWriter, commandDispatcher, unitEffector);

            engine.Start();
        }
    }
}