using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_AddChatAndNotiTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Classes_ClassId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Dogs_DogId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Availability_Schedule_ScheduleId",
                table: "Availability");

            migrationBuilder.DropForeignKey(
                name: "FK_Availability_TrainerProfiles_TrainerProfileId",
                table: "Availability");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_StaffProfiles_StaffProfileId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_Courses_CourseId",
                table: "Certificate");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseEquipment_Courses_CourseId",
                table: "CourseEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseEquipment_Equipment_EquipmentId",
                table: "CourseEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_DogCertificate_Certificate_CertificateId",
                table: "DogCertificate");

            migrationBuilder.DropForeignKey(
                name: "FK_DogCertificate_Dogs_DogId",
                table: "DogCertificate");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Cage_CageId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prerequisite_Courses_CourseId",
                table: "Prerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_Prerequisite_Courses_PrerequisiteCourseId",
                table: "Prerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressReport_Attendance_AttendanceId",
                table: "ProgressReport");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressReport_TrainerProfiles_TrainerProfileId",
                table: "ProgressReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Slot_Classes_ClassId",
                table: "Slot");

            migrationBuilder.DropForeignKey(
                name: "FK_Slot_Schedule_ScheduleId",
                table: "Slot");

            migrationBuilder.DropForeignKey(
                name: "FK_SlotEquipment_CourseEquipment_CourseEquipmentId",
                table: "SlotEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_SlotEquipment_Slot_SlotId",
                table: "SlotEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerAssignment_Classes_ClassId",
                table: "TrainerAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerAssignment_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReport_CustomerProfiles_CustomerProfileId",
                table: "TrainerReport");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReport_TrainerProfiles_TrainerProfileId",
                table: "TrainerReport");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReport_Dogs_DogId",
                table: "TrainingReport");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReport_TrainerProfiles_TrainerProfileId",
                table: "TrainingReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingReport",
                table: "TrainingReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainerReport",
                table: "TrainerReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainerAssignment",
                table: "TrainerAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlotEquipment",
                table: "SlotEquipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Slot",
                table: "Slot");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgressReport",
                table: "ProgressReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prerequisite",
                table: "Prerequisite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DogCertificate",
                table: "DogCertificate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseEquipment",
                table: "CourseEquipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificate",
                table: "Certificate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cage",
                table: "Cage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Availability",
                table: "Availability");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.RenameTable(
                name: "TrainingReport",
                newName: "TrainingReports");

            migrationBuilder.RenameTable(
                name: "TrainerReport",
                newName: "TrainerReports");

            migrationBuilder.RenameTable(
                name: "TrainerAssignment",
                newName: "TrainerAssignments");

            migrationBuilder.RenameTable(
                name: "SlotEquipment",
                newName: "SlotEquipments");

            migrationBuilder.RenameTable(
                name: "Slot",
                newName: "Slots");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "Schedules");

            migrationBuilder.RenameTable(
                name: "ProgressReport",
                newName: "ProgressReports");

            migrationBuilder.RenameTable(
                name: "Prerequisite",
                newName: "Prerequisites");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "Equipments");

            migrationBuilder.RenameTable(
                name: "DogCertificate",
                newName: "DogCertificates");

            migrationBuilder.RenameTable(
                name: "CourseEquipment",
                newName: "CourseEquipments");

            migrationBuilder.RenameTable(
                name: "Certificate",
                newName: "Certificates");

            migrationBuilder.RenameTable(
                name: "Cage",
                newName: "Cages");

            migrationBuilder.RenameTable(
                name: "Blog",
                newName: "Blogs");

            migrationBuilder.RenameTable(
                name: "Availability",
                newName: "Availabilities");

            migrationBuilder.RenameTable(
                name: "Attendance",
                newName: "Attendances");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingReport_TrainerProfileId",
                table: "TrainingReports",
                newName: "IX_TrainingReports_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingReport_DogId",
                table: "TrainingReports",
                newName: "IX_TrainingReports_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerReport_TrainerProfileId",
                table: "TrainerReports",
                newName: "IX_TrainerReports_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerReport_CustomerProfileId",
                table: "TrainerReports",
                newName: "IX_TrainerReports_CustomerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerAssignment_TrainerProfileId",
                table: "TrainerAssignments",
                newName: "IX_TrainerAssignments_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerAssignment_ClassId",
                table: "TrainerAssignments",
                newName: "IX_TrainerAssignments_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_SlotEquipment_SlotId",
                table: "SlotEquipments",
                newName: "IX_SlotEquipments_SlotId");

            migrationBuilder.RenameIndex(
                name: "IX_SlotEquipment_CourseEquipmentId",
                table: "SlotEquipments",
                newName: "IX_SlotEquipments_CourseEquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Slot_ScheduleId",
                table: "Slots",
                newName: "IX_Slots_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Slot_ClassId",
                table: "Slots",
                newName: "IX_Slots_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgressReport_TrainerProfileId",
                table: "ProgressReports",
                newName: "IX_ProgressReports_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgressReport_AttendanceId",
                table: "ProgressReports",
                newName: "IX_ProgressReports_AttendanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Prerequisite_PrerequisiteCourseId",
                table: "Prerequisites",
                newName: "IX_Prerequisites_PrerequisiteCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Prerequisite_CourseId",
                table: "Prerequisites",
                newName: "IX_Prerequisites_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_DogCertificate_DogId",
                table: "DogCertificates",
                newName: "IX_DogCertificates_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_DogCertificate_CertificateId",
                table: "DogCertificates",
                newName: "IX_DogCertificates_CertificateId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEquipment_EquipmentId",
                table: "CourseEquipments",
                newName: "IX_CourseEquipments_EquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEquipment_CourseId",
                table: "CourseEquipments",
                newName: "IX_CourseEquipments_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Certificate_CourseId",
                table: "Certificates",
                newName: "IX_Certificates_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_StaffProfileId",
                table: "Blogs",
                newName: "IX_Blogs_StaffProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Availability_TrainerProfileId",
                table: "Availabilities",
                newName: "IX_Availabilities_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Availability_ScheduleId",
                table: "Availabilities",
                newName: "IX_Availabilities_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_DogId",
                table: "Attendances",
                newName: "IX_Attendances_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_ClassId",
                table: "Attendances",
                newName: "IX_Attendances_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingReports",
                table: "TrainingReports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainerReports",
                table: "TrainerReports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainerAssignments",
                table: "TrainerAssignments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlotEquipments",
                table: "SlotEquipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slots",
                table: "Slots",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgressReports",
                table: "ProgressReports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prerequisites",
                table: "Prerequisites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DogCertificates",
                table: "DogCertificates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseEquipments",
                table: "CourseEquipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cages",
                table: "Cages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Accounts_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chats_Accounts_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Accounts_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WishLists_CustomerProfiles_CustomerProfileId",
                        column: x => x.CustomerProfileId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ReceiverId",
                table: "Chats",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_SenderId",
                table: "Chats",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ReceiverId",
                table: "Notifications",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_CourseId",
                table: "WishLists",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_CustomerProfileId",
                table: "WishLists",
                column: "CustomerProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Classes_ClassId",
                table: "Attendances",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Dogs_DogId",
                table: "Attendances",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_Schedules_ScheduleId",
                table: "Availabilities",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_TrainerProfiles_TrainerProfileId",
                table: "Availabilities",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_StaffProfiles_StaffProfileId",
                table: "Blogs",
                column: "StaffProfileId",
                principalTable: "StaffProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Courses_CourseId",
                table: "Certificates",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEquipments_Courses_CourseId",
                table: "CourseEquipments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEquipments_Equipments_EquipmentId",
                table: "CourseEquipments",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DogCertificates_Certificates_CertificateId",
                table: "DogCertificates",
                column: "CertificateId",
                principalTable: "Certificates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DogCertificates_Dogs_DogId",
                table: "DogCertificates",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Cages_CageId",
                table: "Enrollments",
                column: "CageId",
                principalTable: "Cages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisites_Courses_CourseId",
                table: "Prerequisites",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisites_Courses_PrerequisiteCourseId",
                table: "Prerequisites",
                column: "PrerequisiteCourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressReports_Attendances_AttendanceId",
                table: "ProgressReports",
                column: "AttendanceId",
                principalTable: "Attendances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressReports_TrainerProfiles_TrainerProfileId",
                table: "ProgressReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SlotEquipments_CourseEquipments_CourseEquipmentId",
                table: "SlotEquipments",
                column: "CourseEquipmentId",
                principalTable: "CourseEquipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SlotEquipments_Slots_SlotId",
                table: "SlotEquipments",
                column: "SlotId",
                principalTable: "Slots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Classes_ClassId",
                table: "Slots",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Schedules_ScheduleId",
                table: "Slots",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerAssignments_Classes_ClassId",
                table: "TrainerAssignments",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerAssignments_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignments",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReports_CustomerProfiles_CustomerProfileId",
                table: "TrainerReports",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReports_TrainerProfiles_TrainerProfileId",
                table: "TrainerReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_Dogs_DogId",
                table: "TrainingReports",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_TrainerProfiles_TrainerProfileId",
                table: "TrainingReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Classes_ClassId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Dogs_DogId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_Schedules_ScheduleId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_TrainerProfiles_TrainerProfileId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_StaffProfiles_StaffProfileId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Courses_CourseId",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseEquipments_Courses_CourseId",
                table: "CourseEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseEquipments_Equipments_EquipmentId",
                table: "CourseEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_DogCertificates_Certificates_CertificateId",
                table: "DogCertificates");

            migrationBuilder.DropForeignKey(
                name: "FK_DogCertificates_Dogs_DogId",
                table: "DogCertificates");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Cages_CageId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prerequisites_Courses_CourseId",
                table: "Prerequisites");

            migrationBuilder.DropForeignKey(
                name: "FK_Prerequisites_Courses_PrerequisiteCourseId",
                table: "Prerequisites");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressReports_Attendances_AttendanceId",
                table: "ProgressReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressReports_TrainerProfiles_TrainerProfileId",
                table: "ProgressReports");

            migrationBuilder.DropForeignKey(
                name: "FK_SlotEquipments_CourseEquipments_CourseEquipmentId",
                table: "SlotEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_SlotEquipments_Slots_SlotId",
                table: "SlotEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Classes_ClassId",
                table: "Slots");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Schedules_ScheduleId",
                table: "Slots");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerAssignments_Classes_ClassId",
                table: "TrainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerAssignments_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReports_CustomerProfiles_CustomerProfileId",
                table: "TrainerReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReports_TrainerProfiles_TrainerProfileId",
                table: "TrainerReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReports_Dogs_DogId",
                table: "TrainingReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReports_TrainerProfiles_TrainerProfileId",
                table: "TrainingReports");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingReports",
                table: "TrainingReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainerReports",
                table: "TrainerReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainerAssignments",
                table: "TrainerAssignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Slots",
                table: "Slots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlotEquipments",
                table: "SlotEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgressReports",
                table: "ProgressReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prerequisites",
                table: "Prerequisites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DogCertificates",
                table: "DogCertificates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseEquipments",
                table: "CourseEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cages",
                table: "Cages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.RenameTable(
                name: "TrainingReports",
                newName: "TrainingReport");

            migrationBuilder.RenameTable(
                name: "TrainerReports",
                newName: "TrainerReport");

            migrationBuilder.RenameTable(
                name: "TrainerAssignments",
                newName: "TrainerAssignment");

            migrationBuilder.RenameTable(
                name: "Slots",
                newName: "Slot");

            migrationBuilder.RenameTable(
                name: "SlotEquipments",
                newName: "SlotEquipment");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "Schedule");

            migrationBuilder.RenameTable(
                name: "ProgressReports",
                newName: "ProgressReport");

            migrationBuilder.RenameTable(
                name: "Prerequisites",
                newName: "Prerequisite");

            migrationBuilder.RenameTable(
                name: "Equipments",
                newName: "Equipment");

            migrationBuilder.RenameTable(
                name: "DogCertificates",
                newName: "DogCertificate");

            migrationBuilder.RenameTable(
                name: "CourseEquipments",
                newName: "CourseEquipment");

            migrationBuilder.RenameTable(
                name: "Certificates",
                newName: "Certificate");

            migrationBuilder.RenameTable(
                name: "Cages",
                newName: "Cage");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.RenameTable(
                name: "Availabilities",
                newName: "Availability");

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "Attendance");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingReports_TrainerProfileId",
                table: "TrainingReport",
                newName: "IX_TrainingReport_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingReports_DogId",
                table: "TrainingReport",
                newName: "IX_TrainingReport_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerReports_TrainerProfileId",
                table: "TrainerReport",
                newName: "IX_TrainerReport_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerReports_CustomerProfileId",
                table: "TrainerReport",
                newName: "IX_TrainerReport_CustomerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerAssignments_TrainerProfileId",
                table: "TrainerAssignment",
                newName: "IX_TrainerAssignment_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerAssignments_ClassId",
                table: "TrainerAssignment",
                newName: "IX_TrainerAssignment_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Slots_ScheduleId",
                table: "Slot",
                newName: "IX_Slot_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Slots_ClassId",
                table: "Slot",
                newName: "IX_Slot_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_SlotEquipments_SlotId",
                table: "SlotEquipment",
                newName: "IX_SlotEquipment_SlotId");

            migrationBuilder.RenameIndex(
                name: "IX_SlotEquipments_CourseEquipmentId",
                table: "SlotEquipment",
                newName: "IX_SlotEquipment_CourseEquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgressReports_TrainerProfileId",
                table: "ProgressReport",
                newName: "IX_ProgressReport_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgressReports_AttendanceId",
                table: "ProgressReport",
                newName: "IX_ProgressReport_AttendanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Prerequisites_PrerequisiteCourseId",
                table: "Prerequisite",
                newName: "IX_Prerequisite_PrerequisiteCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Prerequisites_CourseId",
                table: "Prerequisite",
                newName: "IX_Prerequisite_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_DogCertificates_DogId",
                table: "DogCertificate",
                newName: "IX_DogCertificate_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_DogCertificates_CertificateId",
                table: "DogCertificate",
                newName: "IX_DogCertificate_CertificateId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEquipments_EquipmentId",
                table: "CourseEquipment",
                newName: "IX_CourseEquipment_EquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEquipments_CourseId",
                table: "CourseEquipment",
                newName: "IX_CourseEquipment_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Certificates_CourseId",
                table: "Certificate",
                newName: "IX_Certificate_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_StaffProfileId",
                table: "Blog",
                newName: "IX_Blog_StaffProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Availabilities_TrainerProfileId",
                table: "Availability",
                newName: "IX_Availability_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Availabilities_ScheduleId",
                table: "Availability",
                newName: "IX_Availability_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_DogId",
                table: "Attendance",
                newName: "IX_Attendance_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_ClassId",
                table: "Attendance",
                newName: "IX_Attendance_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingReport",
                table: "TrainingReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainerReport",
                table: "TrainerReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainerAssignment",
                table: "TrainerAssignment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slot",
                table: "Slot",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlotEquipment",
                table: "SlotEquipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgressReport",
                table: "ProgressReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prerequisite",
                table: "Prerequisite",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DogCertificate",
                table: "DogCertificate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseEquipment",
                table: "CourseEquipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificate",
                table: "Certificate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cage",
                table: "Cage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Availability",
                table: "Availability",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Classes_ClassId",
                table: "Attendance",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Dogs_DogId",
                table: "Attendance",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Availability_Schedule_ScheduleId",
                table: "Availability",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Availability_TrainerProfiles_TrainerProfileId",
                table: "Availability",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_StaffProfiles_StaffProfileId",
                table: "Blog",
                column: "StaffProfileId",
                principalTable: "StaffProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_Courses_CourseId",
                table: "Certificate",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEquipment_Courses_CourseId",
                table: "CourseEquipment",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEquipment_Equipment_EquipmentId",
                table: "CourseEquipment",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DogCertificate_Certificate_CertificateId",
                table: "DogCertificate",
                column: "CertificateId",
                principalTable: "Certificate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DogCertificate_Dogs_DogId",
                table: "DogCertificate",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Cage_CageId",
                table: "Enrollments",
                column: "CageId",
                principalTable: "Cage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisite_Courses_CourseId",
                table: "Prerequisite",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisite_Courses_PrerequisiteCourseId",
                table: "Prerequisite",
                column: "PrerequisiteCourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressReport_Attendance_AttendanceId",
                table: "ProgressReport",
                column: "AttendanceId",
                principalTable: "Attendance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressReport_TrainerProfiles_TrainerProfileId",
                table: "ProgressReport",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slot_Classes_ClassId",
                table: "Slot",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slot_Schedule_ScheduleId",
                table: "Slot",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SlotEquipment_CourseEquipment_CourseEquipmentId",
                table: "SlotEquipment",
                column: "CourseEquipmentId",
                principalTable: "CourseEquipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SlotEquipment_Slot_SlotId",
                table: "SlotEquipment",
                column: "SlotId",
                principalTable: "Slot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerAssignment_Classes_ClassId",
                table: "TrainerAssignment",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerAssignment_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignment",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReport_CustomerProfiles_CustomerProfileId",
                table: "TrainerReport",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReport_TrainerProfiles_TrainerProfileId",
                table: "TrainerReport",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReport_Dogs_DogId",
                table: "TrainingReport",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReport_TrainerProfiles_TrainerProfileId",
                table: "TrainingReport",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
