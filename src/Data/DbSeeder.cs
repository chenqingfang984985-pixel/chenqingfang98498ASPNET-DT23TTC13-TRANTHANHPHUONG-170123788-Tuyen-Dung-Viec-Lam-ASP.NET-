using TuyenDungViecLam.Models;

namespace TuyenDungViecLam.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (context.Categories.Any()) return;

            // Seed Categories
            var categories = new List<Category>
            {
                new Category { Id = "1", Name = "Công nghệ thông tin", JobCount = 8 },
                new Category { Id = "2", Name = "Marketing", JobCount = 2 },
                new Category { Id = "3", Name = "Kinh doanh", JobCount = 3 },
                new Category { Id = "4", Name = "Thiết kế", JobCount = 2 },
                new Category { Id = "5", Name = "Tài chính", JobCount = 1 },
                new Category { Id = "6", Name = "Giáo dục", JobCount = 0 }
            };
            context.Categories.AddRange(categories);

            // Seed Employers
            var employers = new List<Employer>
            {
                new Employer
                {
                    Id = "1",
                    Name = "TechViet Solutions",
                    Logo = "https://images.pexels.com/photos/356056/pexels-photo-356056.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Description = "Công ty công nghệ hàng đầu chuyên phát triển phần mềm cho doanh nghiệp",
                    Website = "https://techviet.com",
                    Email = "hr@techviet.com",
                    Phone = "024-3456-7890",
                    Address = "Tầng 15, Tòa nhà ABC, Cầu Giấy, Hà Nội",
                    Industry = "Công nghệ thông tin",
                    Size = "100-500 nhân viên",
                    Jobs = new List<string> { "1", "2", "3", "11" }
                },
                new Employer
                {
                    Id = "2",
                    Name = "Digital Marketing Pro",
                    Logo = "https://images.pexels.com/photos/270408/pexels-photo-270408.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Description = "Chuyên gia về marketing số và quảng cáo trực tuyến",
                    Website = "https://digitalmarketingpro.vn",
                    Email = "careers@digitalmarketingpro.vn",
                    Phone = "028-9876-5432",
                    Address = "123 Nguyễn Huệ, Quận 1, TP.HCM",
                    Industry = "Marketing",
                    Size = "50-100 nhân viên",
                    Jobs = new List<string> { "4", "5" }
                },
                new Employer
                {
                    Id = "3",
                    Name = "VietBiz Corp",
                    Logo = "https://images.pexels.com/photos/277593/pexels-photo-277593.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Description = "Tập đoàn kinh doanh đa ngành với 20 năm kinh nghiệm",
                    Website = "https://vietbiz.com",
                    Email = "recruitment@vietbiz.com",
                    Phone = "024-1234-5678",
                    Address = "Tòa nhà Vietbiz Tower, Ba Đình, Hà Nội",
                    Industry = "Kinh doanh",
                    Size = "500+ nhân viên",
                    Jobs = new List<string> { "6", "7", "12" }
                },
                new Employer
                {
                    Id = "4",
                    Name = "Creative Design Studio",
                    Logo = "https://images.pexels.com/photos/196644/pexels-photo-196644.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Description = "Studio thiết kế sáng tạo chuyên về branding và UI/UX",
                    Website = "https://creativedesign.vn",
                    Email = "hello@creativedesign.vn",
                    Phone = "028-5555-6666",
                    Address = "456 Lê Lợi, Quận 3, TP.HCM",
                    Industry = "Thiết kế",
                    Size = "20-50 nhân viên",
                    Jobs = new List<string> { "8", "9" }
                },
                new Employer
                {
                    Id = "5",
                    Name = "VietFinance Bank",
                    Logo = "https://images.pexels.com/photos/259027/pexels-photo-259027.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Description = "Ngân hàng thương mại hàng đầu tại Việt Nam",
                    Website = "https://vietfinance.vn",
                    Email = "hr@vietfinance.vn",
                    Phone = "024-7777-8888",
                    Address = "789 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội",
                    Industry = "Tài chính",
                    Size = "1000+ nhân viên",
                    Jobs = new List<string> { "10" }
                }
            };
            context.Employers.AddRange(employers);

            // Seed Jobs
            var jobs = new List<Job>
            {
                new Job
                {
                    Id = "1",
                    Title = "Senior Frontend Developer",
                    Company = "TechViet Solutions",
                    Logo = "https://images.pexels.com/photos/356056/pexels-photo-356056.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "Hà Nội",
                    Salary = "20-30 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Công nghệ thông tin",
                    Description = "Chúng tôi đang tìm kiếm một Senior Frontend Developer có kinh nghiệm để tham gia vào đội ngũ phát triển sản phẩm.",
                    Requirements = new List<string> { "3+ năm kinh nghiệm với React/TypeScript", "Thành thạo HTML5, CSS3, JavaScript ES6+", "Kinh nghiệm với Redux, Context API" },
                    Benefits = new List<string> { "Lương thỏa thuận theo năng lực", "Bảo hiểm sức khỏe cao cấp", "14 tháng lương/năm" },
                    PostedDate = DateTime.Parse("2025-12-20"),
                    EmployerId = "1",
                    IsActive = true
                },
                new Job
                {
                    Id = "2",
                    Title = "Backend Developer (Node.js)",
                    Company = "TechViet Solutions",
                    Logo = "https://images.pexels.com/photos/356056/pexels-photo-356056.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "Hà Nội",
                    Salary = "18-25 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Công nghệ thông tin",
                    Description = "Tham gia phát triển các hệ thống backend scalable sử dụng Node.js, Express, và MongoDB.",
                    Requirements = new List<string> { "2+ năm kinh nghiệm Node.js/Express", "Thành thạo MongoDB, PostgreSQL", "Kinh nghiệm với RESTful APIs" },
                    Benefits = new List<string> { "Lương cạnh tranh", "Remote work 2 ngày/tuần", "Laptop và thiết bị làm việc" },
                    PostedDate = DateTime.Parse("2025-12-19"),
                    EmployerId = "1",
                    IsActive = true
                },
                new Job
                {
                    Id = "3",
                    Title = "Mobile App Developer (Flutter)",
                    Company = "TechViet Solutions",
                    Logo = "https://images.pexels.com/photos/356056/pexels-photo-356056.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "Hà Nội",
                    Salary = "16-22 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Công nghệ thông tin",
                    Description = "Phát triển ứng dụng mobile đa nền tảng sử dụng Flutter framework.",
                    Requirements = new List<string> { "2+ năm kinh nghiệm Flutter/Dart", "Hiểu biết về iOS và Android development", "Kinh nghiệm với Firebase" },
                    Benefits = new List<string> { "Lương cạnh tranh theo năng lực", "Thiết bị làm việc hiện đại", "Flexible working time" },
                    PostedDate = DateTime.Parse("2025-12-18"),
                    EmployerId = "1",
                    IsActive = true
                },
                new Job
                {
                    Id = "4",
                    Title = "Digital Marketing Specialist",
                    Company = "Digital Marketing Pro",
                    Logo = "https://images.pexels.com/photos/270408/pexels-photo-270408.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "TP.HCM",
                    Salary = "12-18 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Marketing",
                    Description = "Thực hiện các chiến dịch marketing số, quản lý social media và tối ưu hóa SEO.",
                    Requirements = new List<string> { "1-2 năm kinh nghiệm Digital Marketing", "Thành thạo Google Ads, Facebook Ads", "Hiểu biết về SEO/SEM" },
                    Benefits = new List<string> { "Thưởng KPI hàng tháng", "Đào tạo chứng chỉ Google/Facebook", "Môi trường trẻ trung" },
                    PostedDate = DateTime.Parse("2025-12-17"),
                    EmployerId = "2",
                    IsActive = true
                },
                new Job
                {
                    Id = "5",
                    Title = "Content Marketing Manager",
                    Company = "Digital Marketing Pro",
                    Logo = "https://images.pexels.com/photos/270408/pexels-photo-270408.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "TP.HCM",
                    Salary = "15-20 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Marketing",
                    Description = "Quản lý và phát triển chiến lược content marketing, tạo nội dung chất lượng cao.",
                    Requirements = new List<string> { "3+ năm kinh nghiệm Content Marketing", "Kỹ năng viết và sáng tạo nội dung", "Kinh nghiệm quản lý team" },
                    Benefits = new List<string> { "Lương thỏa thuận", "Bonus theo performance", "Cơ hội sáng tạo cao" },
                    PostedDate = DateTime.Parse("2025-12-16"),
                    EmployerId = "2",
                    IsActive = true
                },
                new Job
                {
                    Id = "6",
                    Title = "Business Analyst",
                    Company = "VietBiz Corp",
                    Logo = "https://images.pexels.com/photos/277593/pexels-photo-277593.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "Hà Nội",
                    Salary = "18-25 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Kinh doanh",
                    Description = "Phân tích quy trình kinh doanh, thu thập yêu cầu và đề xuất giải pháp cải thiện.",
                    Requirements = new List<string> { "2+ năm kinh nghiệm Business Analysis", "Thành thạo Excel, SQL, Power BI", "Tiếng Anh giao tiếp tốt" },
                    Benefits = new List<string> { "Lương cạnh tranh", "Đào tạo chuyên sâu", "Cơ hội thăng tiến" },
                    PostedDate = DateTime.Parse("2025-12-15"),
                    EmployerId = "3",
                    IsActive = true
                },
                new Job
                {
                    Id = "7",
                    Title = "Project Manager (IT)",
                    Company = "VietBiz Corp",
                    Logo = "https://images.pexels.com/photos/277593/pexels-photo-277593.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "Hà Nội",
                    Salary = "22-30 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Kinh doanh",
                    Description = "Quản lý các dự án công nghệ thông tin từ khởi tạo đến triển khai.",
                    Requirements = new List<string> { "3+ năm kinh nghiệm quản lý dự án IT", "Chứng chỉ PMP hoặc tương đương", "Hiểu biết về Agile/Scrum" },
                    Benefits = new List<string> { "Lương cao + bonus", "Cơ hội quản lý dự án lớn", "Thăng tiến nhanh" },
                    PostedDate = DateTime.Parse("2025-12-14"),
                    EmployerId = "3",
                    IsActive = true
                },
                new Job
                {
                    Id = "8",
                    Title = "UI/UX Designer",
                    Company = "Creative Design Studio",
                    Logo = "https://images.pexels.com/photos/196644/pexels-photo-196644.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "TP.HCM",
                    Salary = "15-22 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Thiết kế",
                    Description = "Thiết kế giao diện người dùng và trải nghiệm người dùng cho các ứng dụng web và mobile.",
                    Requirements = new List<string> { "2+ năm kinh nghiệm UI/UX Design", "Thành thạo Figma, Adobe Creative Suite", "Portfolio ấn tượng" },
                    Benefits = new List<string> { "Môi trường sáng tạo", "Thiết bị Apple đầy đủ", "Flexible working" },
                    PostedDate = DateTime.Parse("2025-12-13"),
                    EmployerId = "4",
                    IsActive = true
                },
                new Job
                {
                    Id = "9",
                    Title = "Graphic Designer",
                    Company = "Creative Design Studio",
                    Logo = "https://images.pexels.com/photos/196644/pexels-photo-196644.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "TP.HCM",
                    Salary = "10-15 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Thiết kế",
                    Description = "Thiết kế các sản phẩm truyền thông trực quan, branding và marketing materials.",
                    Requirements = new List<string> { "1-2 năm kinh nghiệm Graphic Design", "Thành thạo Photoshop, Illustrator, InDesign", "Có khiếu thẩm mỹ tốt" },
                    Benefits = new List<string> { "Môi trường sáng tạo", "Học hỏi từ senior designers", "Flexible time" },
                    PostedDate = DateTime.Parse("2025-12-12"),
                    EmployerId = "4",
                    IsActive = true
                },
                new Job
                {
                    Id = "10",
                    Title = "Financial Analyst",
                    Company = "VietFinance Bank",
                    Logo = "https://images.pexels.com/photos/259027/pexels-photo-259027.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "Hà Nội",
                    Salary = "18-25 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Tài chính",
                    Description = "Phân tích tài chính, đánh giá rủi ro và hỗ trợ ra quyết định đầu tư.",
                    Requirements = new List<string> { "Bằng cử nhân Tài chính/Kế toán", "2+ năm kinh nghiệm phân tích tài chính", "Thành thạo Excel, SQL" },
                    Benefits = new List<string> { "Lương tháng 13, 14", "Bảo hiểm toàn diện", "Training quốc tế" },
                    PostedDate = DateTime.Parse("2025-12-11"),
                    EmployerId = "5",
                    IsActive = true
                },
                new Job
                {
                    Id = "11",
                    Title = "DevOps Engineer",
                    Company = "TechViet Solutions",
                    Logo = "https://images.pexels.com/photos/356056/pexels-photo-356056.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "Hà Nội",
                    Salary = "22-32 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Công nghệ thông tin",
                    Description = "Xây dựng và duy trì hạ tầng cloud, tự động hóa quy trình CI/CD.",
                    Requirements = new List<string> { "3+ năm kinh nghiệm DevOps", "Thành thạo AWS/Azure, Docker, Kubernetes", "Kỹ năng scripting (Python, Bash)" },
                    Benefits = new List<string> { "Lương cao + stock options", "Làm việc với công nghệ mới nhất", "Remote work linh hoạt" },
                    PostedDate = DateTime.Parse("2025-12-10"),
                    EmployerId = "1",
                    IsActive = true
                },
                new Job
                {
                    Id = "12",
                    Title = "Data Scientist",
                    Company = "VietBiz Corp",
                    Logo = "https://images.pexels.com/photos/277593/pexels-photo-277593.jpeg?auto=compress&cs=tinysrgb&w=100&h=100&fit=crop",
                    Location = "TP.HCM",
                    Salary = "25-35 triệu VNĐ",
                    Type = JobType.FullTime,
                    Category = "Công nghệ thông tin",
                    Description = "Phân tích dữ liệu lớn, xây dựng mô hình machine learning và cung cấp insights.",
                    Requirements = new List<string> { "Thạc sĩ Data Science/Statistics", "3+ năm kinh nghiệm Data Science", "Thành thạo Python, R, SQL" },
                    Benefits = new List<string> { "Lương top market", "Làm việc với dữ liệu thực tế", "Thiết bị high-end" },
                    PostedDate = DateTime.Parse("2025-12-04"),
                    EmployerId = "3",
                    IsActive = true
                }
            };
            context.Jobs.AddRange(jobs);

            // Seed phuongtran84
            var phuongtran84 = new List<phuongtran84>
            {
                new phuongtran84
                {
                    Id = "1",
                    Name = "Trần Thanh Phương",
                    Email = "chenqingfang984985@gmail.com",
                    Phone = "0902995232",
                    Avatar = "https://images.pexels.com/photos/2379004/pexels-photo-2379004.jpeg?auto=compress&cs=tinysrgb&w=150&h=150&fit=crop",
                    Title = "Senior Frontend Developer",
                    Experience = "4 years",
                    Skills = new List<string> { "React", "TypeScript", "Node.js", "MongoDB" },
                    Education = "Cử nhân Công nghệ thông tin - ĐH Trà Vinh",
                    Resume = "resume_tran_thanh_phuong.pdf"
                }
            };
            context.phuongtran84.AddRange(phuongtran84);

            await context.SaveChangesAsync();
        }
    }
}