// Copyright (C) 2016-2017 David Pol. All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement,
// a copy of which is available at http://unity3d.com/company/legal/as_terms.

namespace CCGKit
{
    /// <summary>
    /// The available game action targets.
    /// ���p�\�ȃQ�[���A�N�V�����^�[�Q�b�g�B
    /// </summary>
    public enum GameActionTarget
    {
        CurrentPlayer,
        CurrentOpponent,
        AllPlayers
    }

    /// <summary>
    /// The base class for game actions.
    /// �Q�[���A�N�V�����̊�{�N���X�B
    /// </summary>
    public abstract class GameAction
    {
        /// <summary>
        /// The name of this action.
        /// ���̃A�N�V�����̖��O
        /// </summary>
        public string name { get; private set; }

        /// <summary>
        /// The target of this action.
        /// ���̃A�N�V�����̃^�[�Q�b�g
        /// </summary>
        public GameActionTarget target;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">The name of the action.</param>
        public GameAction(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Resolves this action.
        /// �������������
        /// </summary>
        /// <param name="state">The state of the game.</param>
        /// <param name="player">The player on which to resolve this action.</param>
        public abstract void Resolve(GameState state, PlayerInfo player);
    }
}
