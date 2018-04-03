using Chess.Model;
using TechTalk.SpecFlow;

namespace Chess.Tests.StepDefinitions
{
    [Binding]
    public class BishopMoveSteps
    {
        [When(@"I ask for bishop valid moves")]
        public void WhenIAskForBishopValidMoves()
        {
            var color = (Color)ScenarioContext.Current[ScenarioContextConstants.Color];
            var initialPosition = (Position)ScenarioContext.Current[ScenarioContextConstants.InitialPosition];

            var bishopMoveExplorer = new BishopMoveExplorer();
            var validPositions = bishopMoveExplorer.GetValidMovesForPosition(initialPosition, color);

            ScenarioContext.Current.Add(ScenarioContextConstants.ValidPositions, validPositions);
        }
    }
}
