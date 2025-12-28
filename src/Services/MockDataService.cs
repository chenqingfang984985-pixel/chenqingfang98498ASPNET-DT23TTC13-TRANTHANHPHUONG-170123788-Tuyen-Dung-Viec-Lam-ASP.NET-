using TuyenDungViecLam.Models;

namespace TuyenDungViecLam.Services
{
    public class MockDataService : IDataService
    {
        private readonly List<Category> _categories;
        private readonly List<Employer> _employers;
        private readonly List<Job> _jobs;
        private readonly List<phuongtran84> _phuongtran84;
        private readonly List<Application> _applications;

        public MockDataService()
        {
            _categories = new List<Category>
            {
                new Category { Id = "1", Name = "Công nghệ thông tin", JobCount = 8 },
                new Category { Id = "2", Name = "Marketing", JobCount = 2 },
                new Category { Id = "3", Name = "Kinh doanh", JobCount = 3 },
                new Category { Id = "4", Name = "Thiết kế", JobCount = 2 },
                new Category { Id = "5", Name = "Tài chính", JobCount = 1 },
                new Category { Id = "6", Name = "Giáo dục", JobCount = 0 }
            };

            _employers = new List<Employer>
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
                    Jobs = new List<string> { "1", "2" }
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
                    Jobs = new List<string> { "3", "4" }
                }
            };

            _jobs = new List<Job>
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
                    Requirements = new List<string>
                    {
                        "3+ năm kinh nghiệm với React/TypeScript",
                        "Thành thạo HTML5, CSS3, JavaScript ES6+",
                        "Kinh nghiệm với Redux, Context API",
                        "Hiểu biết về responsive design",
                        "Kinh nghiệm với Git và Agile/Scrum"
                    },
                    Benefits = new List<string>
                    {
                        "Lương thỏa thuận theo năng lực",
                        "Bảo hiểm sức khỏe cao cấp",
                        "14 tháng lương/năm",
                        "Môi trường làm việc hiện đại",
                        "Cơ hội đào tạo và phát triển"
                    },
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
                    Requirements = new List<string>
                    {
                        "2+ năm kinh nghiệm Node.js/Express",
                        "Thành thạo MongoDB, PostgreSQL",
                        "Kinh nghiệm với RESTful APIs",
                        "Hiểu biết về microservices",
                        "Kinh nghiệm với Docker và AWS"
                    },
                    Benefits = new List<string>
                    {
                        "Lương cạnh tranh",
                        "Laptop và thiết bị làm việc",
                        "Team building hàng quý",
                        "Flexible working hours",
                        "Remote work 2 ngày/tuần"
                    },
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
                    Description = "Phát triển ứng dụng mobile đa nền tảng sử dụng Flutter framework. Làm việc với team thiết kế để tạo ra những ứng dụng mobile tuyệt vời.",
                    Requirements = new List<string>
                    {
                        "2+ năm kinh nghiệm Flutter/Dart",
                        "Hiểu biết về iOS và Android development",
                        "Kinh nghiệm với RESTful APIs",
                        "Thành thạo Git và CI/CD",
                        "Kinh nghiệm với Firebase"
                    },
                    Benefits = new List<string>
                    {
                        "Lương cạnh tranh theo năng lực",
                        "Thiết bị làm việc hiện đại",
                        "Đào tạo công nghệ mới",
                        "Flexible working time",
                        "Bảo hiểm đầy đủ"
                    },
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
                    Description = "Thực hiện các chiến dịch marketing số, quản lý social media và tối ưu hóa SEO cho các khách hàng.",
                    Requirements = new List<string>
                    {
                        "1-2 năm kinh nghiệm Digital Marketing",
                        "Thành thạo Google Ads, Facebook Ads",
                        "Kinh nghiệm với Google Analytics",
                        "Kỹ năng viết content tốt",
                        "Hiểu biết về SEO/SEM"
                    },
                    Benefits = new List<string>
                    {
                        "Thưởng KPI hàng tháng",
                        "Đào tạo chứng chỉ Google/Facebook",
                        "Môi trường trẻ trung",
                        "Cơ hội thăng tiến",
                        "Team building định kỳ"
                    },
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
                    Description = "Quản lý và phát triển chiến lược content marketing, tạo nội dung chất lượng cao cho các kênh digital.",
                    Requirements = new List<string>
                    {
                        "3+ năm kinh nghiệm Content Marketing",
                        "Kỹ năng viết và sáng tạo nội dung",
                        "Hiểu biết về content strategy",
                        "Thành thạo các công cụ design",
                        "Kinh nghiệm quản lý team"
                    },
                    Benefits = new List<string>
                    {
                        "Lương thỏa thuận",
                        "Bonus theo performance",
                        "Cơ hội sáng tạo cao",
                        "Đào tạo skills mới",
                        "Văn phòng hiện đại"
                    },
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
                    Description = "Phân tích quy trình kinh doanh, thu thập yêu cầu và đề xuất giải pháp cải thiện hiệu quả hoạt động.",
                    Requirements = new List<string>
                    {
                        "2+ năm kinh nghiệm Business Analysis",
                        "Thành thạo Excel, SQL, Power BI",
                        "Kỹ năng phân tích dữ liệu",
                        "Hiểu biết về quy trình kinh doanh",
                        "Tiếng Anh giao tiếp tốt"
                    },
                    Benefits = new List<string>
                    {
                        "Lương cạnh tranh",
                        "Đào tạo chuyên sâu",
                        "Cơ hội thăng tiến",
                        "Bảo hiểm cao cấp",
                        "Môi trường chuyên nghiệp"
                    },
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
                    Description = "Quản lý các dự án công nghệ thông tin từ khởi tạo đến triển khai, đảm bảo dự án hoàn thành đúng tiến độ và chất lượng.",
                    Requirements = new List<string>
                    {
                        "3+ năm kinh nghiệm quản lý dự án IT",
                        "Chứng chỉ PMP hoặc tương đương",
                        "Hiểu biết về Agile/Scrum",
                        "Kỹ năng leadership và communication",
                        "Kinh nghiệm với các công cụ quản lý dự án"
                    },
                    Benefits = new List<string>
                    {
                        "Lương cao + bonus",
                        "Cơ hội quản lý dự án lớn",
                        "Đào tạo quản lý",
                        "Thăng tiến nhanh",
                        "Môi trường quốc tế"
                    },
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
                    Description = "Thiết kế giao diện người dùng và trải nghiệm người dùng cho các ứng dụng web và mobile, nghiên cứu user behavior.",
                    Requirements = new List<string>
                    {
                        "2+ năm kinh nghiệm UI/UX Design",
                        "Thành thạo Figma, Adobe Creative Suite",
                        "Hiểu biết về Design System",
                        "Portfolio ấn tượng",
                        "Khả năng user research và testing"
                    },
                    Benefits = new List<string>
                    {
                        "Môi trường sáng tạo",
                        "Thiết bị Apple đầy đủ",
                        "Flexible working",
                        "Tham gia dự án lớn",
                        "Đào tạo design trends"
                    },
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
                    Description = "Thiết kế các sản phẩm truyền thông trực quan, branding và marketing materials cho các khách hàng đa dạng.",
                    Requirements = new List<string>
                    {
                        "1-2 năm kinh nghiệm Graphic Design",
                        "Thành thạo Photoshop, Illustrator, InDesign",
                        "Có khiếu thẩm mỹ tốt",
                        "Portfolio đa dạng",
                        "Kỹ năng làm việc nhóm"
                    },
                    Benefits = new List<string>
                    {
                        "Môi trường sáng tạo",
                        "Học hỏi từ senior designers",
                        "Cơ hội phát triển skills",
                        "Flexible time",
                        "Bonus theo dự án"
                    },
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
                    Description = "Phân tích tài chính, đánh giá rủi ro và hỗ trợ ra quyết định đầu tư. Lập báo cáo tài chính và theo dõi performance.",
                    Requirements = new List<string>
                    {
                        "Bằng cử nhân Tài chính/Kế toán",
                        "2+ năm kinh nghiệm phân tích tài chính",
                        "Thành thạo Excel, SQL",
                        "Chứng chỉ CFA/FRM là lợi thế",
                        "Kỹ năng phân tích dữ liệu"
                    },
                    Benefits = new List<string>
                    {
                        "Lương tháng 13, 14",
                        "Bảo hiểm toàn diện",
                        "Vay ưu đãi cho nhân viên",
                        "Training quốc tế",
                        "Cơ hội thăng tiến"
                    },
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
                    Description = "Xây dựng và duy trì hạ tầng cloud, tự động hóa quy trình CI/CD, monitoring và đảm bảo tính ổn định của hệ thống.",
                    Requirements = new List<string>
                    {
                        "3+ năm kinh nghiệm DevOps",
                        "Thành thạo AWS/Azure, Docker, Kubernetes",
                        "Kinh nghiệm với Jenkins, GitLab CI/CD",
                        "Hiểu biết về Infrastructure as Code",
                        "Kỹ năng scripting (Python, Bash)"
                    },
                    Benefits = new List<string>
                    {
                        "Lương cao + stock options",
                        "Làm việc với công nghệ mới nhất",
                        "Remote work linh hoạt",
                        "Đào tạo cloud certifications",
                        "Môi trường tech startup"
                    },
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
                    Description = "Phân tích dữ liệu lớn, xây dựng mô hình machine learning và cung cấp insights để hỗ trợ quyết định kinh doanh.",
                    Requirements = new List<string>
                    {
                        "Thạc sĩ Data Science/Statistics/Computer Science",
                        "3+ năm kinh nghiệm Data Science",
                        "Thành thạo Python, R, SQL",
                        "Kinh nghiệm với ML frameworks (TensorFlow, PyTorch)",
                        "Hiểu biết về Big Data technologies"
                    },
                    Benefits = new List<string>
                    {
                        "Lương top market",
                        "Làm việc với dữ liệu thực tế",
                        "Cơ hội research và publish",
                        "Đào tạo AI/ML courses",
                        "Thiết bị high-end"
                    },
                    PostedDate = DateTime.Parse("2025-12-04"),
                    EmployerId = "3",
                    IsActive = true
                }
            };

            _phuongtran84 = new List<phuongtran84>
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

            _applications = new List<Application>
            {
                new Application
                {
                    Id = "1",
                    JobId = "1",
                    CandidateId = "1",
                    AppliedDate = DateTime.Parse("2025-12-25"),
                    Status = ApplicationStatus.Pending,
                    CoverLetter = "Tôi rất quan tâm đến vị trí Senior Frontend Developer tại công ty..."
                }
            };
        }

        public Task<List<Job>> GetJobsAsync()
        {
            return Task.FromResult(_jobs);
        }

        public Task<Job?> GetJobByIdAsync(string id)
        {
            var job = _jobs.FirstOrDefault(j => j.Id == id);
            return Task.FromResult(job);
        }

        public Task<List<Employer>> GetEmployersAsync()
        {
            return Task.FromResult(_employers);
        }

        public Task<Employer?> GetEmployerByIdAsync(string id)
        {
            var employer = _employers.FirstOrDefault(e => e.Id == id);
            return Task.FromResult(employer);
        }

        public Task<List<Category>> GetCategoriesAsync()
        {
            return Task.FromResult(_categories);
        }

        public Task<List<phuongtran84>> Getphuongtran84Async()
        {
            return Task.FromResult(_phuongtran84);
        }

        public Task<List<Application>> GetApplicationsAsync()
        {
            return Task.FromResult(_applications);
        }

        public Task<List<Job>> SearchJobsAsync(string? keyword, string? location, string? category)
        {
            var query = _jobs.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(j => j.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                        j.Company.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(location))
            {
                query = query.Where(j => j.Location.Contains(location, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(j => j.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            }

            return Task.FromResult(query.ToList());
        }
    }
}