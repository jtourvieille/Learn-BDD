using System;
using System.Collections.Generic;
using System.Linq;
using Chess.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Chess.Tests.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        [Given(@"A (.*) is placed at the initial position (.*)")]
        public void GivenAPieceIsPlacedAtTheInitialPosition(string piece, string initialPosition)
        {
            var domainInitialPosition = GetPositionFromString(initialPosition);

            ScenarioContext.Current.Add(ScenarioContextConstants.InitialPosition, domainInitialPosition);
        }

        [Given(@"The piece color is (.*)")]
        public void GivenThePieceColorIs(string color)
        {
            var domainColor = (Color)Enum.Parse(typeof(Color), color);
            ScenarioContext.Current.Add(ScenarioContextConstants.Color, domainColor);
        }

        [Then(@"Moves to the positions (.*) are valid")]
        public void ThenMovesToThePositionsAreValid(string expectedValidPositions)
        {
            List<Position> domainExpectedValidPositions = new List<Position>();

            foreach (var expectedValidPosition in expectedValidPositions.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                domainExpectedValidPositions.Add(GetPositionFromString(expectedValidPosition));
            }

            var domainActualComputedPositions = (List<Position>)ScenarioContext.Current[ScenarioContextConstants.ValidPositions];

            Assert.IsTrue(domainExpectedValidPositions.All(domainActualComputedPositions.Contains));
        }

        [Then(@"Moves to the positions (.*) are invalid")]
        public void ThenMovesToThePositionsAreInvalid(string expectedInvalidPositions)
        {
            List<Position> domainExpectedInvalidPositions = new List<Position>();

            foreach (var expectedInvalidPosition in expectedInvalidPositions.Split(','))
            {
                domainExpectedInvalidPositions.Add(GetPositionFromString(expectedInvalidPosition));
            }

            var domainActualComputedPositions = (List<Position>)ScenarioContext.Current[ScenarioContextConstants.ValidPositions];
            var initialCount = domainActualComputedPositions.Count;

            var actualMinusInvalidCount = domainActualComputedPositions.Except(domainExpectedInvalidPositions).Count();

            Assert.AreEqual(initialCount, actualMinusInvalidCount);
        }

        private Position GetPositionFromString(string position)
        {
            return new Position(
                int.Parse(position[0].ToString()),
                int.Parse(position[1].ToString()));
        }
    }
}
