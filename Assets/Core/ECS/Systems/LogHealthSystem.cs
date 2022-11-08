using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Core
{
	public class LogHealthSystem : ReactiveSystem<GameEntity>
	{
		public LogHealthSystem(Contexts contexts) : base(contexts.game)
		{
		}
		
		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.Health);
		}

		protected override bool Filter(GameEntity entity)
		{
			return entity.hasHealth;
		}

		protected override void Execute(List<GameEntity> entities)
		{
			foreach (var health in entities)
			{
				Debug.Log(health.health.health);
			}
		}
	}
}