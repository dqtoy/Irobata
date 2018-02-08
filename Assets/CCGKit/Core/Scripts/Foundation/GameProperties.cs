using System.Collections.Generic;

namespace CCGKit
{
    /// <summary>
    /// The general properties of a game.
    /// �Q�[���̈�ʓI�ȃv���p�e�B
    /// </summary>
    public class GameProperties
    {
        /// <summary>
        /// Duration of a game turn (in seconds).
        /// 1�^�[���̎���(�b)
        /// </summary>
        public int turnDuration;

        /// <summary>
        /// Minimum number of cards that need to be in a deck.
        /// �f�b�L�ɓ���Ȃ���΂Ȃ�Ȃ��J�[�h�̍ŏ������B
        /// </summary>
        public int minDeckSize;

        /// <summary>
        /// Maximum number of cards that can be in a deck.
        /// �f�b�L�ɓ���Ȃ���΂Ȃ�Ȃ��J�[�h�̍ő喇���B
        /// </summary>
        public int maxDeckSize;

        /// <summary>
        /// List of actions to perform when a game starts.
        /// �Q�[���J�n���Ɏ��s����A�N�V�����̃��X�g�B
        /// </summary>
        public List<GameAction> gameStartActions = new List<GameAction>();

        /// <summary>
        /// List of actions to perform when a turn starts.
        /// �^�[���J�n���Ɏ��s����A�N�V�����̃��X�g�B
        /// </summary>
        public List<GameAction> turnStartActions = new List<GameAction>();

        /// <summary>
        /// List of actions to perform when a turn ends.
        /// �^�[���I�����Ɏ��s����A�N�V�����̃��X�g
        /// </summary>
        public List<GameAction> turnEndActions = new List<GameAction>();

        /// <summary>
        /// List of end game conditions of this game.
        /// �Q�[���I�����̏�ԃ��X�g
        /// </summary>
        public List<EndGameCondition> endGameConditions = new List<EndGameCondition>();
    }
}