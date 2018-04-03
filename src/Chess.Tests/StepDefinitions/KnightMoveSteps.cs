using Chess.Model;
using TechTalk.SpecFlow;

namespace Chess.Tests.StepDefinitions
{
    [Binding]
    public class KnightMoveSteps
    {
        [When(@"I ask for knight valid moves")]
        public void WhenIAskForKnightValidMoves()
        {
            var color = (Color)ScenarioContext.Current[ScenarioContextConstants.Color];
            var initialPosition = (Position)ScenarioContext.Current[ScenarioContextConstants.InitialPosition];

            var knightMoveExplorer = new KnightMoveExplorer();
            var validPositions = knightMoveExplorer.GetValidMovesForPosition(initialPosition, color);

            ScenarioContext.Current.Add(ScenarioContextConstants.ValidPositions, validPositions);
        }
    }
}
