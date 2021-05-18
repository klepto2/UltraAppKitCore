%rename("%s") UltraEngine::ListenEvent;
%rename("%s") UltraEngine::CreateThread;

%inline %{
typedef bool (__stdcall* ProcessEventHandler)(const UltraEngine::Event&, shared_ptr<UltraEngine::Object>);
typedef shared_ptr<UltraEngine::Object> (__stdcall* EntryPointHandler)(shared_ptr<UltraEngine::Object> o);

class FunctionDelegate
{
public:
	virtual void Execute() = 0;
};

class FunctionHandler
{
private:
	FunctionDelegate* delegate_;
public:
	FunctionHandler(FunctionDelegate* d)
	{
		delegate_ = d;
	}

	void operator()() const
	{
		delegate_->Execute();
	}
};

void ListenEvent(const UltraEngine::EventID id, shared_ptr<UltraEngine::Object> source, FunctionDelegate* callback)
{
	UltraEngine::ListenEvent(id, source, FunctionHandler(callback));
}

void ListenEvent_Internal(const UltraEngine::EventID id, shared_ptr<UltraEngine::Object> source, ProcessEventHandler callback, shared_ptr<UltraEngine::Object> extra = NULL)
{
	UltraEngine::ListenEvent(id, source, callback, extra);
}

shared_ptr<UltraEngine::Thread> CreateThread_Internal(EntryPointHandler entryPoint, shared_ptr<UltraEngine::Object> o = nullptr, const bool start = false)
{
	return UltraEngine::CreateThread(entryPoint, o, start);
}

shared_ptr<UltraEngine::Thread> CreateThread(FunctionDelegate* instruction, const bool start = false)
{
	return UltraEngine::CreateThread(FunctionHandler(instruction), start);
}
%}