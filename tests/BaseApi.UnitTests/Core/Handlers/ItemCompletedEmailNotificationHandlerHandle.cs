﻿using BaseApi.Core.Interfaces;
using BaseApi.Core.ProjectAggregate;
using BaseApi.Core.ProjectAggregate.Events;
using BaseApi.Core.ProjectAggregate.Handlers;
using Moq;
using Xunit;

namespace BaseApi.UnitTests.Core.Handlers;

public class ItemCompletedEmailNotificationHandlerHandle
{
  private ItemCompletedEmailNotificationHandler _handler;
  private Mock<IEmailSender> _emailSenderMock;

  public ItemCompletedEmailNotificationHandlerHandle()
  {
    _emailSenderMock = new Mock<IEmailSender>();
    _handler = new ItemCompletedEmailNotificationHandler(_emailSenderMock.Object);
  }

  [Fact]
  public async Task ThrowsExceptionGivenNullEventArgument()
  {
#nullable disable
    Exception ex = await Assert.ThrowsAsync<ArgumentNullException>(() => _handler.Handle(null, CancellationToken.None));
#nullable enable
  }

  [Fact]
  public async Task SendsEmailGivenEventInstance()
  {
    await _handler.Handle(new ToDoItemCompletedEvent(new ToDoItem()), CancellationToken.None);

    _emailSenderMock.Verify(sender => sender.SendEmailAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
  }
}
