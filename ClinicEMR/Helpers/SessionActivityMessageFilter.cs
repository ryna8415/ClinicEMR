using System;
using System.Windows.Forms;

namespace ClinicEMR.Helpers
{
    internal sealed class SessionActivityMessageFilter : IMessageFilter
    {
        public event EventHandler? ActivityDetected;

        public bool PreFilterMessage(ref Message m)
        {
            if (IsActivityMessage(m.Msg))
            {
                ActivityDetected?.Invoke(this, EventArgs.Empty);
            }

            return false;
        }

        private static bool IsActivityMessage(int messageId)
        {
            return messageId is >= 0x0100 and <= 0x0108
                or >= 0x0200 and <= 0x020E
                or 0x00A0
                or 0x00A1
                or 0x0112;
        }
    }
}
