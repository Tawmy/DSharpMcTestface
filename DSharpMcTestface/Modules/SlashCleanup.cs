using System.Globalization;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;

namespace DSharpMcTestface.Modules;

[SlashCommandGroup("SlashCleanup", "Test various command types and converters")]
public class SlashCleanup : ApplicationCommandModule
{
    /* #region SByte

    [SlashCommand("SByteNonNullable", "description")]
    public async Task SlashSByteNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] sbyte value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("SByteNullable", "description")]
    public async Task SlashSByteNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] sbyte? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("SByteNullableOptional", "description")]
    public async Task SlashSByteNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] sbyte? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */

    #region String

    [SlashCommand("StringNonNullable", "description")]
    public async Task SlashStringNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] string value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value));
    }

/*
    [SlashCommand("StringNullable", "description")]
    public async Task SlashStringNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] string? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value ?? "value null"));
    }

    [SlashCommand("StringNullableOptional", "description")]
    public async Task SlashStringNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] string? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value ?? "value null"));
    }
*/

    #endregion

    #region Boolean

    [SlashCommand("BooleanNonNullable", "description")]
    public async Task SlashBooleanNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] bool value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("BooleanNullable", "description")]
    public async Task SlashBooleanNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] bool? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("BooleanNullableOptional", "description")]
    public async Task SlashBooleanNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] bool? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion

    /* #region Byte

    [SlashCommand("ByteNonNullable", "description")]
    public async Task SlashByteNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] byte value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("ByteNullable", "description")]
    public async Task SlashByteNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] byte? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("ByteNullableOptional", "description")]
    public async Task SlashByteNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] byte? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */

    #region DiscordAttachment

    [SlashCommand("DiscordAttachmentNonNullable", "description")]
    public async Task SlashDiscordAttachmentNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordAttachment value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString() ?? "value null"));
    }

    [SlashCommand("DiscordAttachmentNullable", "description")]
    public async Task SlashDiscordAttachmentNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordAttachment? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("DiscordAttachmentNullableOpt", "description")]
    public async Task SlashDiscordAttachmentNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordAttachment? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion

    #region DiscordChannel

    [SlashCommand("DiscordChannelNonNullable", "description")]
    public async Task SlashDiscordChannelNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordChannel value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("DiscordChannelNullable", "description")]
    public async Task SlashDiscordChannelNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordChannel? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("DiscordChannelNullableOptional", "description")]
    public async Task SlashDiscordChannelNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordChannel? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion

    #region DiscordEmoji

    [SlashCommand("DiscordEmojiNonNullable", "description")]
    public async Task SlashDiscordEmojiNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordEmoji value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("DiscordEmojiNullable", "description")]
    public async Task SlashDiscordEmojiNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordEmoji? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("DiscordEmojiNullableOptional", "description")]
    public async Task SlashDiscordEmojiNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordEmoji? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion

    /* #region DiscordMember

    [SlashCommand("DiscordMemberNonNullable", "description")]
    public async Task SlashDiscordMemberNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordMember value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("DiscordMemberNullable", "description")]
    public async Task SlashDiscordMemberNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordMember? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("DiscordMemberNullableOptional", "description")]
    public async Task SlashDiscordMemberNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordMember? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */

    /* #region DiscordMessage

    [SlashCommand("DiscordMessageNonNullable", "description")]
    public async Task SlashDiscordMessageNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordMessage value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("DiscordMessageNullable", "description")]
    public async Task SlashDiscordMessageNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordMessage? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("DiscordMessageNullableOptional", "description")]
    public async Task SlashDiscordMessageNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordMessage? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */

    #region DiscordRole

    [SlashCommand("DiscordRoleNonNullable", "description")]
    public async Task SlashDiscordRoleNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordRole value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("DiscordRoleNullable", "description")]
    public async Task SlashDiscordRoleNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordRole? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("DiscordRoleNullableOptional", "description")]
    public async Task SlashDiscordRoleNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordRole? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion

    #region DiscordUser

    [SlashCommand("DiscordUserNonNullable", "description")]
    public async Task SlashDiscordUserNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordUser value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("DiscordUserNullable", "description")]
    public async Task SlashDiscordUserNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordUser? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("DiscordUserNullableOptional", "description")]
    public async Task SlashDiscordUserNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] DiscordUser? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion

    #region Double

    [SlashCommand("DoubleNonNullable", "description")]
    public async Task SlashDoubleNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] double value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString(CultureInfo.InvariantCulture)));
    }

    [SlashCommand("DoubleNullable", "description")]
    public async Task SlashDoubleNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] double? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString(CultureInfo.InvariantCulture) ??
                                                                "value null"));
    }

    [SlashCommand("DoubleNullableOptional", "description")]
    public async Task SlashDoubleNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] double? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString(CultureInfo.InvariantCulture) ??
                                                                "value null"));
    }

    #endregion

    /* #region Int16

    [SlashCommand("Int16NonNullable", "description")]
    public async Task SlashInt16NonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] short value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("Int16Nullable", "description")]
    public async Task SlashInt16NullableAsync(InteractionContext ctx,
        [Option("value", "Value")] short? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("Int16NullableOptional", "description")]
    public async Task SlashInt16NullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] short? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */

    /* #region Int32

    [SlashCommand("Int32NonNullable", "description")]
    public async Task SlashInt32NonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] int value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("Int32Nullable", "description")]
    public async Task SlashInt32NullableAsync(InteractionContext ctx,
        [Option("value", "Value")] int? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("Int32NullableOptional", "description")]
    public async Task SlashInt32NullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] int? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */

    #region Int64

    [SlashCommand("LongNonNullable", "description")]
    public async Task SlashInt64NonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] long value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("LongNullable", "description")]
    public async Task SlashInt64NullableAsync(InteractionContext ctx,
        [Option("value", "Value")] long? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("LongNullableOptional", "description")]
    public async Task SlashInt64NullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] long? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion

    /* #region TimeSpan

    [SlashCommand("TimeSpanNonNullable", "description")]
    public async Task SlashTimeSpanNonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] TimeSpan value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("TimeSpanNullable", "description")]
    public async Task SlashTimeSpanNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] TimeSpan? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("TimeSpanNullableOptional", "description")]
    public async Task SlashTimeSpanNullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] TimeSpan? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */

    /* #region UInt16

    [SlashCommand("UInt16NonNullable", "description")]
    public async Task SlashUInt16NonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] ushort value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("UInt16Nullable", "description")]
    public async Task SlashUInt16NullableAsync(InteractionContext ctx,
        [Option("value", "Value")] ushort? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("UInt16NullableOptional", "description")]
    public async Task SlashUInt16NullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] ushort? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */

    /* #region UInt32

    [SlashCommand("UInt32NonNullable", "description")]
    public async Task SlashUInt32NonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] uint value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("UInt32Nullable", "description")]
    public async Task SlashUInt32NullableAsync(InteractionContext ctx,
        [Option("value", "Value")] uint? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("UInt32NullableOptional", "description")]
    public async Task SlashUInt32NullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] uint? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion
    
    */

    /*
     
    #region UInt64

    [SlashCommand("ULongNonNullable", "description")]
    public async Task SlashUInt64NonNullableAsync(InteractionContext ctx,
        [Option("value", "Value")] ulong value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value.ToString()));
    }

    [SlashCommand("ULongNullable", "description")]
    public async Task SlashUInt64NullableAsync(InteractionContext ctx,
        [Option("value", "Value")] ulong? value)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    [SlashCommand("ULongNullableOptional", "description")]
    public async Task SlashUInt64NullableOptionalAsync(InteractionContext ctx,
        [Option("value", "Value")] ulong? value = null)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent(value?.ToString() ?? "value null"));
    }

    #endregion */
}