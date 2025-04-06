namespace DriveShare.Frontend.Services
{
    public abstract class SecurityQuestionHandler
    {
        protected SecurityQuestionHandler? _nextHandler;

        public SecurityQuestionHandler SetNext(SecurityQuestionHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public abstract Task<bool> Handle(SecurityQuestionValidationRequest request);
    }

    public class Question1Handler : SecurityQuestionHandler
    {
        public override async Task<bool> Handle(SecurityQuestionValidationRequest request)
        {
            if (request.Answer1 != request.StoredAnswer1)
            {
                return false;
            }

            return _nextHandler == null || await _nextHandler.Handle(request);
        }
    }

    public class Question2Handler : SecurityQuestionHandler
    {
        public override async Task<bool> Handle(SecurityQuestionValidationRequest request)
        {
            if (request.Answer2 != request.StoredAnswer2)
            {
                return false;
            }

            return _nextHandler == null || await _nextHandler.Handle(request);
        }
    }

    public class Question3Handler : SecurityQuestionHandler
    {
        public override async Task<bool> Handle(SecurityQuestionValidationRequest request)
        {
            if (request.Answer3 != request.StoredAnswer3)
            {
                return false;
            }

            return true;
        }
    }

    public class SecurityQuestionValidationRequest
    {
        public string Answer1 { get; set; } = string.Empty;
        public string Answer2 { get; set; } = string.Empty;
        public string Answer3 { get; set; } = string.Empty;
        public string StoredAnswer1 { get; set; } = string.Empty;
        public string StoredAnswer2 { get; set; } = string.Empty;
        public string StoredAnswer3 { get; set; } = string.Empty;
    }
}