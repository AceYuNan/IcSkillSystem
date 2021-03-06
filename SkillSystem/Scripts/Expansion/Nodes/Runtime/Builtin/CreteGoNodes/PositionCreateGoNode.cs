//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年11月17日-21:55
//CabinIcarus.IcSkillSystem.Expansion.Runtime

using UnityEngine;

namespace CabinIcarus.IcSkillSystem.Expansion.Runtime.Builtin.Nodes
{
    [CreateNodeMenuAttribute("CabinIcarus/IcSkillSystem/Behave Nodes/Task/Actions/Create GameObject/Position")]
    public class PositionCreateGoNode:ACreateGoNode
    {
        //基于自身坐标
        [Input(ShowBackingValue.Always,ConnectionType.Override,TypeConstraint.Strict)]
        [SerializeField]
        private bool _basedOnItselfPos = true;
        
        [Input(ShowBackingValue.Always,ConnectionType.Override,TypeConstraint.Strict)]
        [SerializeField]
        private Vector3 _pos;

        protected override GameObject CreateGo()
        {
            var pos = GetInputValue(nameof(_pos),_pos);

            if (_basedOnItselfPos)
            {
                pos += SkillGroup.Owner.transform.position;
            }
            
            return Instantiate(Go,pos, Quaternion);
        }
    }
}