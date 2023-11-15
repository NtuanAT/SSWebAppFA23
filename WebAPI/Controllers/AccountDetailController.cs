using Microsoft.AspNetCore.Mvc;
using DataLayer.Entities;
using DataLayer.Repositories;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountDetailController : Controller
    {
        private readonly AccountDetailRepository _accountDetailRepository;
        

        public AccountDetailController(AccountDetailRepository accountDetailRepository)
        {
            _accountDetailRepository = accountDetailRepository;
        }

        #region Get All Account Detail
        /// <summary>
        /// Get All Account Detail
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllAccountDetail")]

        public IActionResult GetAllaccountDetail()
        {
            ICollection<AccountDetailViewModel> accountDetails = new List<AccountDetailViewModel>();
            var result = _accountDetailRepository.GetAll();
            try
            {
                foreach(var accountDetailModel in result)
                {
                    AccountDetailViewModel model = new AccountDetailViewModel();
                    model.Id = accountDetailModel.Id;
                    model.AccountId = accountDetailModel.AccountId;
                    model.Avatar = accountDetailModel.Avatar;
                    model.Fullname = accountDetailModel.Fullname;
                    model.Address = accountDetailModel.Address;
                    model.Phone = accountDetailModel.Phone;
                    model.Gender = accountDetailModel.Gender;
                    accountDetails.Add(model);

                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = false,
                    message = ex.Message
                });
            }
            return new JsonResult(new
            {
                status = true,
                message = "Get all Account Detail successful",
                data = accountDetails
            });
        }
        #endregion

        #region Get Account Detail By AccountID
        /// <summary>
        /// Get Account Detail By AccountID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAccountDetailByAccountId/{id}")]
        public IActionResult GetAccountDetailByAccountId(Guid id)
        {

            try
            {
                var accountDetail = _accountDetailRepository.Get(x => x.AccountId == id);
                if (accountDetail == null)
                {
                    return new JsonResult(new
                    {
                        status = false,
                        message = "Account not found"
                    });


                }

                var accountDetailViewModel = new AccountDetailViewModel()
                {
                    Id = accountDetail.Id,
                    AccountId = accountDetail.AccountId,
                    Avatar = accountDetail.Avatar,
                    Fullname = accountDetail.Fullname,
                    Address = accountDetail.Address,
                    Phone = accountDetail.Phone,
                    Gender = accountDetail.Gender,
                    
                };

				return new JsonResult(new
				{
					status = true,
					message = "Get Account Detail by id success",
					data = accountDetailViewModel
				});
			}
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = false,
                    message = ex.Message
                });
            }
        }
        #endregion

        #region Add Account Detail
        /// <summary>
        /// Add accountDetail
        /// </summary>
        /// <param name="accountDetail"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddAccountDetail")]
        public IActionResult AddAccountDetail([FromBody] AccountDetailViewModel accountDetailModel)
        {
            try
            {

                var accountDetail = new AccountDetail
                {
                    // Map properties manually
                    AccountId = accountDetailModel.AccountId,
                    Avatar = accountDetailModel.Avatar,
                    Fullname = accountDetailModel.Fullname,
                    Address = accountDetailModel.Address,
                    Phone = accountDetailModel.Phone,
                    Gender = accountDetailModel.Gender
                    // Map other properties as needed
                };

                _accountDetailRepository.Add(accountDetail);
                _accountDetailRepository.SaveChanges();
                return new JsonResult(new
                {
                    status = true,
                    message = "Add Account Detail success"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = false,
                    message = ex.Message
                });
            }
        }
        #endregion

        #region Update Account Detail
        /// <summary>	
        /// Update accountDetail
        /// </summary>
        /// <param name="accountDetail"></param>
        /// <returns></returns>
        [HttpPatch]
        [Route("UpdateAccountDetail")]
        public IActionResult UpdateAccountDetail([FromBody] AccountDetailViewModel accountDetailViewModel)
        {
            try
            {
                var accountDetail = new AccountDetail
                {
                    Id = accountDetailViewModel.AccountId,
                    AccountId = accountDetailViewModel.AccountId,
                    Avatar = accountDetailViewModel.Avatar,
                    Fullname = accountDetailViewModel.Fullname,
                    Address = accountDetailViewModel.Address,
                    Phone = accountDetailViewModel.Phone,
                    Gender = accountDetailViewModel.Gender
                };
                _accountDetailRepository.Update(accountDetail);
                _accountDetailRepository.SaveChanges();
                return new JsonResult(new
                {
                    status = true,
                    message = "Update accountDetail success"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = false,
                    message = ex.Message
                });
            }
        }
        #endregion

        #region Delete Account Detail
        /// <summary>
        /// Delete accountDetail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteAccountDetail/{id}")]
        public IActionResult DeleteAccountDetail(Guid id)
        {
            try
            {
                var accountDetail = _accountDetailRepository.Get(x => x.AccountId == id);

                if (accountDetail == null)
                {
                    return new JsonResult(new
                    {
                        status = false,
                        message = "Account not found"
                    });


                }
                else
                {
					_accountDetailRepository.Delete(id);
					_accountDetailRepository.SaveChanges();

					return new JsonResult(new
                    {
                        status = true,
                        message = "Delete Account Detail success"
                    });
                }
            }
             
            
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = false,
                    message = ex.Message
                });
            }
        }
        #endregion
    }
}
