﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付 - 查询单笔退款 - 返回参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_10.shtml">JSAPI支付 - 查询单笔退款</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_10.shtml">APP支付 - 查询单笔退款</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_10.shtml">H5支付 - 查询单笔退款</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_10.shtml">Native支付 - 查询单笔退款</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_10.shtml">小程序支付 - 查询单笔退款</a></para>
    /// 最新更新时间：2021.1.15
    /// </summary>
    public class WeChatPayRefundDomesticRefundsOutRefundNoResponse : WeChatPayResponse
    {
        /// <summary>
        /// 微信支付退款号
        /// 微信支付退款号。
        /// 示例值：50000000382019052709732678859
        /// </summary>
        [JsonPropertyName("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 商户退款单号
        /// 商户系统内部的退款单号，商户系统内部唯一，只能是数字、大小写字母_-|*@ ，同一退款单号多次请求只退一笔。
        /// 示例值：1217752501201407033233368018
        /// </summary>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 微信支付订单号
        /// 微信支付交易订单号。
        /// 示例值：1217752501201407033233368018
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// 原支付交易对应的商户订单号。
        /// 示例值：1217752501201407033233368018
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款渠道
        /// 枚举值：
        /// ORIGINAL：原路退款
        /// BALANCE：退回到余额
        /// OTHER_BALANCE：原账户异常退到其他余额账户
        /// OTHER_BANKCARD：原银行卡异常退到其他银行卡
        /// 示例值：ORIGINAL
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 退款入账账户
        /// 取当前退款单的退款入账方，有以下几种情况：
        /// 1）退回银行卡：{银行名称}{卡类型}{卡尾号}
        /// 2）退回支付用户零钱: 支付用户零钱
        /// 3）退还商户: 商户基本账户商户结算银行账户
        /// 4）退回支付用户零钱通: 支付用户零钱通。
        /// 示例值：招商银行信用卡0403
        /// </summary>
        [JsonPropertyName("user_received_account")]
        public string UserReceivedAccount { get; set; }

        /// <summary>
        /// 退款成功时间
        /// 退款成功时间，当退款状态为退款成功时有返回。
        /// 示例值：2020-12-01T16:18:12+08:00
        /// </summary>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }

        /// <summary>
        /// 退款创建时间
        /// 退款受理时间。
        /// 示例值：2020-12-01T16:18:12+08:00
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 退款状态
        /// 退款到银行发现用户的卡作废或者冻结了，导致原路退款银行卡失败，可前往商户平台-交易中心，手动处理此笔退款。
        /// 枚举值：
        /// SUCCESS：退款成功
        /// CLOSED：退款关闭
        /// PROCESSING：退款处理中
        /// ABNORMAL：退款异常
        /// 示例值：SUCCESS
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 资金账户
        /// 退款所使用资金对应的资金账户类型。 枚举值：
        /// UNSETTLED : 未结算资金
        /// AVAILABLE : 可用余额
        /// UNAVAILABLE : 不可用余额
        /// OPERATION : 运营户
        /// 示例值：UNSETTLED
        /// </summary>
        [JsonPropertyName("funds_account")]
        public string FundsAccount { get; set; }

        /// <summary>
        /// 金额信息
        /// 金额详细信息。
        /// </summary>
        [JsonPropertyName("amount")]
        public RefundAmountResponse Amount { get; set; }

        /// <summary>
        /// 优惠退款信息
        /// 优惠退款信息。
        /// </summary>
        [JsonPropertyName("promotion_detail")]
        public List<RefundPromotionDetail> PromotionDetail { get; set; }
    }
}