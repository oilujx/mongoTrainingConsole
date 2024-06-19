using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omsMongoConsole
{
    public class orden
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string acceptance_decision_date { get; set; }
        public bool can_cancel { get; set; }
        public bool can_evaluate { get; set; }
        public bool can_shop_ship { get; set; }
        public string channel { get; set; }
        public string commercial_id { get; set; }
        public string created_date { get; set; }
        public string currency_iso_code { get; set; }
        public Customer customer { get; set; }
        public string customer_debited_date { get; set; }
        public bool customer_directly_pays_seller { get; set; }
        public DeliveryDate delivery_date { get; set; }
        public Fulfillment fulfillment { get; set; }
        public bool fully_refunded { get; set; }
        public bool has_customer_message { get; set; }
        public bool has_incident { get; set; }
        public bool has_invoice { get; set; }
        public InvoiceDetails invoice_details { get; set; }
        public string last_updated_date { get; set; }
        public int leadtime_to_ship { get; set; }
        public List<string> order_additional_fields { get; set; }
        public string order_id { get; set; }
        public List<OrderLine> order_lines { get; set; }
        public string order_state { get; set; }
        public string order_state_reason_code { get; set; }
        public string order_state_reason_label { get; set; }
        public string order_tax_mode { get; set; }
        public string order_taxes { get; set; }
        public string paymentType { get; set; }
        public string payment_type { get; set; }
        public string payment_workflow { get; set; }
        public double price { get; set; }
        public Promotions promotions { get; set; }
        public string quote_id { get; set; }
        public References references { get; set; }
        public string shipping_carrier_code { get; set; }
        public string shipping_carrier_standard_code { get; set; }
        public string shipping_company { get; set; }
        public string shipping_deadline { get; set; }
        public double shipping_price { get; set; }
        public string shipping_pudo_id { get; set; }
        public string shipping_tracking { get; set; }
        public string shipping_tracking_url { get; set; }
        public string shipping_type_code { get; set; }
        public string shipping_type_label { get; set; }
        public string shipping_type_standard_code { get; set; }
        public string shipping_zone_code { get; set; }
        public string shipping_zone_label { get; set; }
        public int shop_id { get; set; }
        public string shop_name { get; set; }
        public double total_commission { get; set; }
        public double total_price { get; set; }
        public bool waiting_tax_confirmation { get; set; }
        public class Address
        {
            public string city { get; set; }
            public string country_iso_code { get; set; }
            public string state { get; set; }
            public string street_1 { get; set; }
            public string street_2 { get; set; }
            public string zip_code { get; set; }
        }

        public class BillingAddress
        {
            public string city { get; set; }
            public string civility { get; set; }
            public string company { get; set; }
            public string company_2 { get; set; }
            public string country { get; set; }
            public string country_iso_code { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string phone { get; set; }
            public string phone_secondary { get; set; }
            public string state { get; set; }
            public string street_1 { get; set; }
            public string street_2 { get; set; }
            public string zip_code { get; set; }
        }

        public class Center
        {
            public string code { get; set; }
        }

        public class CommissionTaxis
        {
            public double amount { get; set; }
            public string code { get; set; }
            public double rate { get; set; }
        }

        public class Customer
        {
            public BillingAddress billing_address { get; set; }
            public string civility { get; set; }
            public string customer_id { get; set; }
            public string email { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string locale { get; set; }
            public ShippingAddress shipping_address { get; set; }
        }

        public class DeliveryDate
        {
            public string earliest { get; set; }
            public string latest { get; set; }
        }

        public class DocumentDetail
        {
            public string format { get; set; }
        }

        public class Fulfillment
        {
            public Center center { get; set; }
        }

        public class InvoiceDetails
        {
            public List<DocumentDetail> document_details { get; set; }
            public PaymentTerms payment_terms { get; set; }
        }

        public class OrderLine
        {
            public bool can_open_incident { get; set; }
            public bool can_refund { get; set; }
            public List<string> cancelations { get; set; }
            public string category_code { get; set; }
            public string category_label { get; set; }
            public double commission_fee { get; set; }
            public double commission_rate_vat { get; set; }
            public List<CommissionTaxis> commission_taxes { get; set; }
            public double commission_vat { get; set; }
            public string created_date { get; set; }
            public string debited_date { get; set; }
            public string description { get; set; }
            public List<string> fees { get; set; }
            public string last_updated_date { get; set; }
            public int offer_id { get; set; }
            public string offer_sku { get; set; }
            public string offer_state_code { get; set; }
            public List<string> order_line_additional_fields { get; set; }
            public string order_line_id { get; set; }
            public int order_line_index { get; set; }
            public string order_line_state { get; set; }
            public string order_line_state_reason_code { get; set; }
            public string order_line_state_reason_label { get; set; }
            public double origin_unit_price { get; set; }
            public double price { get; set; }
            public string price_additional_info { get; set; }
            public double price_unit { get; set; }
            public List<ProductMedia> product_medias { get; set; }
            public string product_sku { get; set; }
            public string product_title { get; set; }
            public List<string> promotions { get; set; }
            public int quantity { get; set; }
            public string received_date { get; set; }
            public List<string> refunds { get; set; }
            public string shipped_date { get; set; }
            public ShippingFrom shipping_from { get; set; }
            public double shipping_price { get; set; }
            public string shipping_price_additional_unit { get; set; }
            public string shipping_price_unit { get; set; }
            public List<string> shipping_taxes { get; set; }
            public string tax_legal_notice { get; set; }
            public bool tax_recalculation_required { get; set; }
            public List<string> taxes { get; set; }
            public double total_commission { get; set; }
            public double total_price { get; set; }
        }

        public class PaymentTerms
        {
            public int days { get; set; }
            public string type { get; set; }
        }

        public class ProductMedia
        {
            public string media_url { get; set; }
            public string mime_type { get; set; }
            public string type { get; set; }
        }

        public class Promotions
        {
            public List<string> applied_promotions { get; set; }
            public int total_deduced_amount { get; set; }
        }

        public class References
        {
            public string order_reference_for_customer { get; set; }
        }       

        public class ShippingAddress
        {
            public string additional_info { get; set; }
            public string city { get; set; }
            public string civility { get; set; }
            public string company { get; set; }
            public string company_2 { get; set; }
            public string country { get; set; }
            public string country_iso_code { get; set; }
            public string firstname { get; set; }
            public string internal_additional_info { get; set; }
            public string lastname { get; set; }
            public string phone { get; set; }
            public string phone_secondary { get; set; }
            public string state { get; set; }
            public string street_1 { get; set; }
            public string street_2 { get; set; }
            public string zip_code { get; set; }
        }

        public class ShippingFrom
        {
            public Address address { get; set; }
        }


    }
}
