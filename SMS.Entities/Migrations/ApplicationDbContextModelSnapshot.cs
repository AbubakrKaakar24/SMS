﻿// <auto-generated />
using System;
using Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SMS.Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("SMS.Entities.AnswerOption", b =>
                {
                    b.Property<int>("AnswerOptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnswerOptionID");

                    b.HasIndex("QuestionID");

                    b.ToTable("AnswersOptions");
                });

            modelBuilder.Entity("SMS.Entities.AnswerOptionTranslation", b =>
                {
                    b.Property<int>("AnswerOptionTranslationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnswerOptionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OptionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnswerOptionTranslationID");

                    b.HasIndex("AnswerOptionID");

                    b.HasIndex("LanguageID");

                    b.ToTable("AnswersOptionsTranslation");
                });

            modelBuilder.Entity("SMS.Entities.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LanguageID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("SMS.Entities.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuestionType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyID")
                        .HasColumnType("INTEGER");

                    b.HasKey("QuestionID");

                    b.HasIndex("SurveyID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("SMS.Entities.QuestionTranslation", b =>
                {
                    b.Property<int>("QuestionTranslationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("QuestionTranslationID");

                    b.HasIndex("LanguageID");

                    b.HasIndex("QuestionID");

                    b.ToTable("QuestionTranslations");
                });

            modelBuilder.Entity("SMS.Entities.Respondent", b =>
                {
                    b.Property<int>("RespondentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RespondentID");

                    b.ToTable("Responsdent");
                });

            modelBuilder.Entity("SMS.Entities.Survey", b =>
                {
                    b.Property<int>("SurveyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SurveyDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SurveyID");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstance", b =>
                {
                    b.Property<int>("SurveyInstanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ActivationDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeactivationDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyInstanceID");

                    b.HasIndex("SurveyID");

                    b.ToTable("SurveyInstances");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstanceQuestion", b =>
                {
                    b.Property<int>("SurveyInstanceQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyInstanceID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyInstanceQuestionID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("SurveyInstanceID");

                    b.ToTable("SurveyInstanceQuestion");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponse", b =>
                {
                    b.Property<int>("SurveyResponseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RespondentID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ResponseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyInstanceID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyResponseID");

                    b.HasIndex("RespondentID");

                    b.HasIndex("SurveyInstanceID");

                    b.ToTable("SurveyResponse");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponseDetail", b =>
                {
                    b.Property<int>("SurveyResponseDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AnswerOptionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FreeTextAnswer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyInstanceQuestionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyResponseID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyResponseDetailID");

                    b.HasIndex("AnswerOptionID");

                    b.HasIndex("SurveyInstanceQuestionID");

                    b.HasIndex("SurveyResponseID");

                    b.ToTable("SurveyResponseDetails");
                });

            modelBuilder.Entity("SMS.Entities.SurveyTranslation", b =>
                {
                    b.Property<int>("SurveyTranslationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SurveyTranslationID");

                    b.HasIndex("LanguageID");

                    b.HasIndex("SurveyID");

                    b.ToTable("SurveyTranslations");
                });

            modelBuilder.Entity("SMS.Entities.AnswerOption", b =>
                {
                    b.HasOne("SMS.Entities.Question", "Question")
                        .WithMany("AnswerOptions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SMS.Entities.AnswerOptionTranslation", b =>
                {
                    b.HasOne("SMS.Entities.AnswerOption", "AnswerOption")
                        .WithMany("Translations")
                        .HasForeignKey("AnswerOptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnswerOption");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("SMS.Entities.Question", b =>
                {
                    b.HasOne("SMS.Entities.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SMS.Entities.QuestionTranslation", b =>
                {
                    b.HasOne("SMS.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.Question", "Question")
                        .WithMany("Translations")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstance", b =>
                {
                    b.HasOne("SMS.Entities.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstanceQuestion", b =>
                {
                    b.HasOne("SMS.Entities.Question", "Question")
                        .WithMany("SurveyInstanceQuestions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.SurveyInstance", "SurveyInstance")
                        .WithMany("SurveyInstanceQuestions")
                        .HasForeignKey("SurveyInstanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("SurveyInstance");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponse", b =>
                {
                    b.HasOne("SMS.Entities.Respondent", "Respondent")
                        .WithMany("SurveyResponses")
                        .HasForeignKey("RespondentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.SurveyInstance", "SurveyInstance")
                        .WithMany("SurveyResponses")
                        .HasForeignKey("SurveyInstanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Respondent");

                    b.Navigation("SurveyInstance");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponseDetail", b =>
                {
                    b.HasOne("SMS.Entities.AnswerOption", "AnswerOption")
                        .WithMany()
                        .HasForeignKey("AnswerOptionID");

                    b.HasOne("SMS.Entities.SurveyInstanceQuestion", "SurveyInstanceQuestion")
                        .WithMany()
                        .HasForeignKey("SurveyInstanceQuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.SurveyResponse", "SurveyResponse")
                        .WithMany("SurveyResponseDetails")
                        .HasForeignKey("SurveyResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnswerOption");

                    b.Navigation("SurveyInstanceQuestion");

                    b.Navigation("SurveyResponse");
                });

            modelBuilder.Entity("SMS.Entities.SurveyTranslation", b =>
                {
                    b.HasOne("SMS.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SMS.Entities.AnswerOption", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("SMS.Entities.Question", b =>
                {
                    b.Navigation("AnswerOptions");

                    b.Navigation("SurveyInstanceQuestions");

                    b.Navigation("Translations");
                });

            modelBuilder.Entity("SMS.Entities.Respondent", b =>
                {
                    b.Navigation("SurveyResponses");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstance", b =>
                {
                    b.Navigation("SurveyInstanceQuestions");

                    b.Navigation("SurveyResponses");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponse", b =>
                {
                    b.Navigation("SurveyResponseDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
