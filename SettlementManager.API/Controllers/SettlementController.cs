using Microsoft.AspNetCore.Mvc;
using SettlementManager.Contract;
using SettlementManager.Messaging.Request;
using SettlementManager.Messaging.View;

namespace SettlementManager.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SettlementController : ControllerBase
	{
		#region Fields

		private readonly ISettlementService _settlementService;

		#endregion

		#region Constructors

		public SettlementController(ISettlementService settlementService)
		{
			_settlementService = settlementService;
		}

		#endregion

		#region SettlementController

		[HttpGet("GetSettlements")]
		public async Task<ActionResult<GetSettlementQueryResponseView>> GetSettlements(int pageNumber, int pageSize)
		{
			var response = await _settlementService.GetSettlementQueryAsync(
				new GetSettlementsQueryRequest
				{
					Query = new GetSettlementQueryRequestView
					{
						PageNumber = pageNumber,
						PageSize = pageSize
					}
				});

			return Ok(response.Query);
		}

		[HttpPost("CreateSettlement")]
		public async Task<IActionResult> CreateSettlementAsync(CreateSettlementView settlement)
		{
			await _settlementService.CreateSettlementAsync(
				new CreateSettlementRequest
				{
					Settlement = settlement
				}
			);

			return Ok();
		}

		[HttpPut("UpdateSettlement")]
		public async Task<IActionResult> UpdateSettlementAsync(UpdateSettlementView settlement)
		{
			await _settlementService.UpdateSettlementAsync(
				new UpdateSettlementRequest
				{
					Settlement = settlement
				}
			);

			return Ok();
		}

		[HttpDelete("DeleteSettlement/{settlementId}")]
		public async Task<IActionResult> DeleteSettlementAsync([FromRoute]long settlementId)
		{
			await _settlementService.DeleteSettlementAsync(
				new DeleteSettlementRequest
				{
					SettlementId = settlementId
				}
			);

			return Ok();
		}

		#endregion
	}
}
