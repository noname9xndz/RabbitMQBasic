using Hangfire;

namespace Micro.Job.Job
{
    public class HangfireJobScheduler
    {
        public static void ScheduleRecurringJobs()
        {
            RecurringJob.AddOrUpdate<HangfireJob>("ChangeTranferPendingStatus", s => s.ChangeStatusTranfer(), Cron.MinuteInterval(2));

            RecurringJob.AddOrUpdate<HangfireJob>("TestChangeTranferSuccessStatus", s => s.TestChangeTranferStatus(), Cron.MinuteInterval(30));
        }
    }
}