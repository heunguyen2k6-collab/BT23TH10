using System;

namespace WindowsFormsApp1
{
    public class MemberModel
    {
        public string MemberId { get; set; }     // Mã HV
        public string FullName { get; set; }     // Họ và tên
        public string Phone { get; set; }        // Số điện thoại
        public string Package { get; set; }      // Gói tập
        public DateTime StartDate { get; set; }  // Ngày đăng ký
        public decimal Fee { get; set; }         // Phí dịch vụ
    }
}