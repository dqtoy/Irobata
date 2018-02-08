using System.Collections.Generic;

namespace CCGKit
{
    /// <summary>
    /// This class stores the current, complete state of a game.
    /// ���̃N���X�́A�Q�[���̌��݂̊��S�ȏ�Ԃ��i�[���܂��B
    /// </summary>
    public class GameState
    {
        /// <summary>
        /// The configuration of this game.
        /// �Q�[���̍\��
        /// </summary>
        public GameConfiguration config;

        /// <summary>
        /// The players of this game.
        /// �Q�[���̃v���C���[���
        /// </summary>
        public List<PlayerInfo> players = new List<PlayerInfo>();

        /// <summary>
        /// The current player of this game.
        /// ���v���C���[���
        /// </summary>
        public PlayerInfo currentPlayer;

        /// <summary>
        /// The current opponent of this game.
        /// �ΐ푊����
        /// </summary>
        public PlayerInfo currentOpponent;

        /// <summary>
        /// The effect solver to use in this game.
        /// ���̃Q�[���Ŏg�p����G�t�F�N�g�̉�����
        /// </summary>
        public EffectSolver effectSolver;
    }
}
