using Chess.Model;
using TechTalk.SpecFlow;

namespace Chess.Tests.StepDefinitions
{
    [Binding]
    public class KingMoveSteps
    {
        [When(@"I ask for king valid moves")]
        public void WhenIAskForKingValidMoves()
        {
            var color = (Color)ScenarioContext.Current[ScenarioContextConstants.Color];
            var initialPosition = (Position)ScenarioContext.Current[ScenarioContextConstants.InitialPosition];

            var kingMoveExplorer = new KingMoveExplorer();
            var validPositions = kingMoveExplorer.GetValidMovesForPosition(initialPosition, color);

            ScenarioContext.Current.Add(ScenarioContextConstants.ValidPositions, validPositions);
        }
    }
}
