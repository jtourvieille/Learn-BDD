using Chess.Model;
using TechTalk.SpecFlow;

namespace Chess.Tests.StepDefinitions
{
    [Binding]
    public class PawnMoveSteps
    {
        [When(@"I ask for pawn valid moves")]
        public void WhenIAskForPawnValidMoves()
        {
            var color = (Color)ScenarioContext.Current[ScenarioContextConstants.Color];
            var initialPosition = (Position)ScenarioContext.Current[ScenarioContextConstants.InitialPosition];

            var pawnMoveExplorer = new PawnMoveExplorer();
            var validPositions = pawnMoveExplorer.GetValidMovesForPosition(initialPosition, color);

            ScenarioContext.Current.Add(ScenarioContextConstants.ValidPositions, validPositions);
        }
    }
}
